using System.ComponentModel.DataAnnotations;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Xml.Linq;

namespace MainProject
{
    public partial class Form1 : Form
    {
        #region Constructors
        public Form1()
        {
            InitializeComponent();
            InitialProgram();
        }
        #endregion

        #region Fields
        // Common
        private INIFile configFile;
        private string startPath;
        private bool IsComConnected = false;
        private bool IsSerConnected = false;
        private bool IsVisionStart = false;
        private bool IsRead = false;
        private string ProtocolType = "";
        private string sttMes = "";

        //Com
        private SerialPort comPort = new SerialPort();
        private int[] BaudRate = new int[] { 4800, 9600, 14400, 19200, 115200 };
        private string ComName = "COM1";
        private int ComBaudRate = 19200;
        private int ComDataBits = 8;
        private Parity ComParity = Parity.None;
        private StopBits ComStopBits = StopBits.One;

        //TCP_IP
        private TcpClient tcpClient;
        private NetworkStream ns;
        private Thread tRecive;
        private IPAddress MC_IP;
        private int MC_Port;
        private IPAddress MODBUS_IP;
        private int MODBUS_Port;
        private byte[] TcpReciveData;
        private string mes;

        //Data Vision
        string objDetect = "";
        float score = 0;
        int x1 = 0, y1 = 0, x2 = 0, y2 = 0;

        #endregion

        #region Methods
        private void InitialProgram()
        {
            startPath = Application.StartupPath;
            configFile = new INIFile(startPath + "config.ini");

            string[] portName = SerialPort.GetPortNames();
            cbbPortName.Items.AddRange(portName);
            cbbPortName.SelectedIndex = 0;

            foreach (int b in BaudRate) { cbbBaudRate.Items.Add(b); }
            cbbBaudRate.SelectedIndex = 1;
            cbbDataBits.SelectedIndex = 3;
            cbbParityBits.SelectedIndex = 0;
            cbbStopBits.SelectedIndex = 0;
            cbbProtocol.SelectedIndex = 0;

            btnLoadConfig_Click(null, null);
            comPort.DataReceived += ComPort_DataReceived;
        }
        #region Open/Close Connection
        bool ComOpen()
        {
            try
            {
                comPort.PortName = ComName;
                comPort.BaudRate = ComBaudRate;
                comPort.DataBits = ComDataBits;
                comPort.Parity = ComParity;
                comPort.StopBits = ComStopBits;
                comPort.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        bool ComClose()
        {
            try
            {
                comPort.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        bool TcpOpen()
        {
            IPAddress ip;
            int port;
            if (ProtocolType == Protocol.MC)
            {
                ip = MC_IP;
                port = MC_Port;
            }
            else
            {
                ip = MODBUS_IP;
                port = MODBUS_Port;
            }
            try
            {
                tcpClient = new TcpClient();
                tcpClient.Connect(ip, port);
                ns = tcpClient.GetStream();
                if (tcpClient != null && tcpClient.Connected)
                {
                    IsSerConnected = true;
                    tRecive = new Thread(ReciveFromServer);
                    tRecive.IsBackground = true;
                    tRecive.Start();
                }
                return true;

            }
            catch
            {
                txbStatus.Text = "Connect Fail!";
                return false;
            }
        }
        bool TcpClose()
        {
            try
            {
                if (tcpClient != null) tcpClient.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        private void ShowData(string nData)
        {
            this.Invoke(new Action(() =>
            {
                lsbShowData.Items.Insert(0, nData);
                if (lsbShowData.Items.Count > 500) lsbShowData.Items.RemoveAt(500);
            }));
        }
        public void WriteDeviceBlockD16(int nAddress, int nLength, Int16 nVal)
        {
            if (!IsSerConnected || ns == null) return;

            byte[] Send2Data = new byte[21 + nLength * 2];
            byte[] MCLength = BitConverter.GetBytes(nLength * 2 + 12);
            byte[] DataLength = BitConverter.GetBytes(nLength);
            byte[] Byteadd = BitConverter.GetBytes(nAddress);

            Send2Data[0] = 0x50;            //sub header
            Send2Data[1] = 0x00;            //sub header
            Send2Data[2] = 0x00;
            Send2Data[3] = 0xFF;
            Send2Data[4] = 0xFF;
            Send2Data[5] = 0x03;
            Send2Data[6] = 0x00;
            Send2Data[7] = MCLength[0];
            Send2Data[8] = MCLength[1];
            Send2Data[9] = 0x10;
            Send2Data[10] = 0x00;
            Send2Data[11] = 0x01;           //write
            Send2Data[12] = 0x14;           //write
            Send2Data[13] = 0x00;
            Send2Data[14] = 0x00;
            Send2Data[15] = Byteadd[0];
            Send2Data[16] = Byteadd[1];
            Send2Data[17] = Byteadd[2];
            Send2Data[18] = 0xA8; // device name "D"
            Send2Data[19] = DataLength[0];
            Send2Data[20] = DataLength[1];

            for (int i = 0; i < nLength; i++)
            {
                byte[] data = BitConverter.GetBytes(nVal);
                Send2Data[21 + i * 2] = data[0];
                Send2Data[21 + i * 2 + 1] = data[1];
            }
            ns.Write(Send2Data, 0, 21 + nLength * 2);

            mes = "";
            for (int i = 0; i < Send2Data.Length; i++)
            {
                mes += Send2Data[i].ToString("X") + " ";
            }
            ShowData("Sent Server: " + mes);
        }
        public void WriteMulDeviceBlockD16(int nAddress, int nLength, Int16[] nVal)
        {
            if (!IsSerConnected || ns == null) return;
            byte[] Send2Data = new byte[21 + nLength * 2];
            byte[] MCLength = BitConverter.GetBytes(nLength * 2 + 12);
            byte[] DataLength = BitConverter.GetBytes(nLength);
            byte[] Byteadd = BitConverter.GetBytes(nAddress);

            Send2Data[0] = 0x50;            //sub header
            Send2Data[1] = 0x00;            //sub header
            Send2Data[2] = 0x00;
            Send2Data[3] = 0xFF;
            Send2Data[4] = 0xFF;
            Send2Data[5] = 0x03;
            Send2Data[6] = 0x00;
            Send2Data[7] = MCLength[0];
            Send2Data[8] = MCLength[1];
            Send2Data[9] = 0x10;
            Send2Data[10] = 0x00;
            Send2Data[11] = 0x01;           //write
            Send2Data[12] = 0x14;           //write
            Send2Data[13] = 0x00;
            Send2Data[14] = 0x00;
            Send2Data[15] = Byteadd[0];
            Send2Data[16] = Byteadd[1];
            Send2Data[17] = Byteadd[2];
            Send2Data[18] = 0xA8; // device name "D"
            Send2Data[19] = DataLength[0];
            Send2Data[20] = DataLength[1];

            for (int i = 0; i < nLength; i++)
            {
                byte[] data = BitConverter.GetBytes(nVal[i]);
                Send2Data[21 + i * 2] = data[0];
                Send2Data[21 + i * 2 + 1] = data[1];
            }
            ns.Write(Send2Data, 0, 21 + nLength * 2);

            mes = "";
            for (int i = 0; i < Send2Data.Length; i++)
            {
                mes += Send2Data[i].ToString("X") + " ";
            }
            ShowData("Sent Server: " + mes);
        }
        public void ReadDeviceBlockD16(int nAddress, int length)
        {
            if (!IsSerConnected || ns == null) return;

            byte[] Send2Data = new byte[21 + length * 2];
            byte[] MCLength = BitConverter.GetBytes(length * 2 + 12);
            byte[] DataLength = BitConverter.GetBytes(length);
            byte[] Byteadd = BitConverter.GetBytes(nAddress);

            Send2Data[0] = 0x50;        //SubHeader
            Send2Data[1] = 0x00;        //SubHeader
            Send2Data[2] = 0x00;        //Access Route - StationNo
            Send2Data[3] = 0xFF;        //Access Route - Network No - 00: Network | FF: PC No
            Send2Data[4] = 0xFF;        //Access Route - StationNo
            Send2Data[5] = 0x03;        //Access Route - StationNo
            Send2Data[6] = 0x00;
            Send2Data[7] = 0x0C;
            Send2Data[8] = 0X00;
            Send2Data[9] = 0x10;
            Send2Data[10] = 0x00;
            Send2Data[11] = 0x01;       //Command        //read
            Send2Data[12] = 0x04;       //Command        //read
            Send2Data[13] = 0x00;       //Subcommand
            Send2Data[14] = 0x00;       //SubCommand
            Send2Data[15] = Byteadd[0];
            Send2Data[16] = Byteadd[1];
            Send2Data[17] = Byteadd[2];
            Send2Data[18] = 0xA8;       // device D
            Send2Data[19] = DataLength[0];
            Send2Data[20] = DataLength[1];

            ns.Write(Send2Data, 0, 21);
        }
        public void WriteDeviceS71200(Int16 stt, int nStartAddr, int nLength, Int16 nVal)
        {
            byte[] Send2Data = new byte[10 + nLength * 2];
            byte[] byteStt = BitConverter.GetBytes(stt);
            byte[] DataLength = BitConverter.GetBytes(nLength);
            byte[] ByteAddr = BitConverter.GetBytes(nStartAddr);
            byte[] ByteValue = BitConverter.GetBytes(nVal);

            Send2Data[0] = byteStt[0];      //So thu tu
            Send2Data[1] = byteStt[1];      //So thu tu: gui the nao cung dc 
            Send2Data[2] = 0x00;            //Protocol Identifier: Nomal 0x00
            Send2Data[3] = 0x00;            //Protocol Identifier: Nomal 0x00
            Send2Data[4] = 0x00;            //Length: do dai goi tin
            Send2Data[5] = 0x06;            //Length: do dai goi tin
            Send2Data[6] = 0x01;            //Unit Identifier: Slave ID
            Send2Data[7] = 0x06;         //Function: dinh dang la viet du lieu
            Send2Data[8] = ByteAddr[1];      //
            Send2Data[9] = ByteAddr[0];      //

            for (int i = 0; i < nLength; i++)
            {
                Send2Data[10 + i * 2] = ByteValue[1];    //
                Send2Data[11 + i * 2] = ByteValue[0];    //
            }
            ns.Write(Send2Data, 0, Send2Data.Length);
        }
        public void WriteMulDeviceS71200(Int16 stt, int add, int len, Int16[] val)
        {
            if (!IsSerConnected || ns == null) return;

            byte[] Send2Data = new byte[13 + len * 2];
            byte[] byteStt = BitConverter.GetBytes(stt);
            byte[] Datalen = BitConverter.GetBytes(9 + (len - 1) * 2);
            byte[] DataLength = BitConverter.GetBytes(len);
            byte[] Byteadd = BitConverter.GetBytes(add);
            byte[] data = new byte[2];

            Send2Data[0] = byteStt[0];
            Send2Data[1] = byteStt[1];
            Send2Data[2] = 0x00;
            Send2Data[3] = 0x00;
            Send2Data[4] = 0x00;
            Send2Data[5] = Datalen[0];
            Send2Data[6] = 0x01;
            Send2Data[7] = 0x10;// dinh dang la viet du lieu
            Send2Data[8] = Byteadd[1];
            Send2Data[9] = Byteadd[0];
            Send2Data[10] = DataLength[1];
            Send2Data[11] = DataLength[0];
            Send2Data[12] = BitConverter.GetBytes(len * 2)[0];

            for (int i = 0; i < len; i++)
            {
                data = BitConverter.GetBytes(val[i]);
                Send2Data[13 + i * 2] = data[1];
                Send2Data[13 + i * 2 + 1] = data[0];
            }
            ns.Write(Send2Data, 0, 13 + len * 2);
        }
        public void CheckDataS71200(Int16 stt, int add, int len)
        {
            byte[] Send2Data = new byte[12];
            byte[] byteStt = BitConverter.GetBytes(stt);
            byte[] Byteadd = BitConverter.GetBytes(add);
            byte[] m_len = BitConverter.GetBytes(len);

            Send2Data[0] = byteStt[1];
            Send2Data[1] = byteStt[0];
            Send2Data[2] = 0x00;
            Send2Data[3] = 0x00;
            Send2Data[4] = 0x00;
            Send2Data[5] = 0x06;
            Send2Data[6] = 0x01;
            Send2Data[7] = 0x03;            // dinh dang la check du lieu
            Send2Data[8] = Byteadd[1];
            Send2Data[9] = Byteadd[0];
            Send2Data[10] = m_len[1];
            Send2Data[11] = m_len[0];

            ns.Write(Send2Data, 0, 12);
        }
        #endregion

        #region Event Handles
        private void OpenConnection_Click(object sender, EventArgs e)
        {
            if (!IsComConnected || !IsSerConnected)
            {
                if (!IsSerConnected)
                    if (TcpOpen()) IsSerConnected = true;
                    else txbStatus.Text = "Server Open Fail!!!";

                if (!IsComConnected)
                    if (ComOpen()) IsComConnected = true;
                    else txbStatus.Text = "Com Open Fail!!!";
            }
            else
            {
                if (ComClose()) IsComConnected = false;
                else txbStatus.Text = "Com Close Fail!!!";

                if (TcpClose()) IsSerConnected = false;
                else txbStatus.Text = "Server Close Fail!!!";
            }
        }
        private void btnTcpOpen_Click(object sender, EventArgs e)
        {
            if (!IsSerConnected)
            {
                if (TcpOpen()) IsSerConnected = true;
                else txbStatus.Text = "Server Open Fail!!!";
            }
            else
            {
                if (TcpClose()) IsSerConnected = false;
                else txbStatus.Text = "Server Close Fail!!!";
            }
        }
        private void btnComOpen_Click(object sender, EventArgs e)
        {
            if (!IsComConnected)
            {
                if (ComOpen()) IsComConnected = true;
                else txbStatus.Text = "Com Open Fail!!!";
            }
            else
            {
                if (ComClose()) IsComConnected = false;
                else txbStatus.Text = "Com Close Fail!!!";
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            lsbShowData.Items.Clear();
        }
        private void btnComSend_Click(object sender, EventArgs e)
        {
            if (IsVisionStart) return;
            if (comPort.IsOpen)
            {
                comPort.WriteLine(txbComSendData.Text);
            }
        }
        private void btnTcpSend_Click(object sender, EventArgs e)
        {
            if (IsVisionStart) return;
            if (tcpClient != null && tcpClient.Connected && ns != null)
            {
                byte[] bData = Encoding.UTF8.GetBytes(txbTCPSendData.Text);
                ns.Write(bData, 0, bData.Length);
            }
        }
        private void PLCWrite_Click(object sender, EventArgs e)
        {
            short data = short.Parse(txbWVal.Text);
            switch (ProtocolType)
            {
                case Protocol.MC:
                    WriteDeviceBlockD16(int.Parse(txbWDev.Text), int.Parse(txbWLength.Text), data);
                    break;
                case Protocol.Modbus:
                    WriteDeviceS71200(1, int.Parse(txbWDev.Text), 1, data);
                    break;
                default:
                    break;
            }
        }
        private void btnPlcRead_Click(object sender, EventArgs e)
        {
            IsRead = true;
            //ReadDeviceBlockD16(txbRDev.Text, 10);
            CheckDataS71200(1, 0, 1);
        }
        private void btnVisStart_Click(object sender, EventArgs e)
        {
            if (!IsVisionStart)
            {
                byte[] comData = Encoding.UTF8.GetBytes("start\r\n");
                comPort.Write(comData, 0, comData.Length);
                IsVisionStart = true;
            }
            else
            {
                byte[] comData = Encoding.UTF8.GetBytes("stop\r\n");
                comPort.Write(comData, 0, comData.Length);
                WriteToPLC(0);
                IsVisionStart = false;
            }
        }

        private void cbbProtocol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsSerConnected)
            {
                if (ProtocolType == Protocol.MC) cbbProtocol.SelectedIndex = 0;
                if (ProtocolType == Protocol.Modbus) cbbProtocol.SelectedIndex = 1;
                return;
            }

            if (cbbProtocol.SelectedIndex == 0) ProtocolType = Protocol.MC;
            if (cbbProtocol.SelectedIndex == 1) ProtocolType = Protocol.Modbus;
        }
        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            configFile.SetData("TCP/IP", "MCIP", txbSerIP.Text);
            configFile.SetData("TCP/IP", "MCPort", txbSerPort.Text);
            configFile.SetData("TCP/IP", "ModbusIP", txbModbusIP.Text);
            configFile.SetData("TCP/IP", "ModbusPort", txbModbusPort.Text);
            configFile.SetData("Serial", "COM Name", cbbPortName.Text);
            configFile.SetData("Serial", "BaudRate", cbbBaudRate.Text);
            configFile.SetData("Serial", "ParityBits", cbbParityBits.SelectedIndex);
            configFile.SetData("Serial", "DataBits", cbbDataBits.Text);
            configFile.SetData("Serial", "StopBits", cbbStopBits.SelectedIndex + 1);
            btnLoadConfig_Click(null, null);
        }
        private void btnLoadConfig_Click(object sender, EventArgs e)
        {
            if (!File.Exists(startPath + "config.ini"))
            {
                btnSaveConfig_Click(null, null);
                return;
            }
            try
            {
                MC_IP = IPAddress.Parse(configFile.GetSData("TCP/IP", "MCIP"));
                MC_Port = configFile.GetIData("TCP/IP", "MCPort");
                MODBUS_IP = IPAddress.Parse(configFile.GetSData("TCP/IP", "ModbusIP"));
                MODBUS_Port = configFile.GetIData("TCP/IP", "ModbusPort");
                txbSerIP.Text = MC_IP.ToString();
                txbSerPort.Text = MC_Port.ToString();
                txbModbusIP.Text = MODBUS_IP.ToString();
                txbModbusPort.Text = MODBUS_Port.ToString();

                ComName = configFile.GetSData("Serial", "COM Name");
                ComBaudRate = configFile.GetIData("Serial", "BaudRate");
                ComParity = (Parity)configFile.GetIData("Serial", "ParityBits");
                ComDataBits = configFile.GetIData("Serial", "DataBits");
                ComStopBits = (StopBits)configFile.GetIData("Serial", "StopBits");
                cbbPortName.SelectedItem = ComName;
                cbbBaudRate.SelectedItem = ComBaudRate;
                cbbParityBits.SelectedIndex = (int)configFile.GetIData("Serial", "ParityBits");
                cbbStopBits.SelectedIndex = (int)configFile.GetIData("Serial", "StopBits") - 1;
                cbbDataBits.SelectedItem = ComDataBits.ToString();

            }
            catch (Exception ex)
            {
                txbStatus.Text = "Load Data Fail!_" + ex.Message.ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            WriteToPLC(0);
        }

        #endregion

        #region Threads
        private void ReciveFromServer()
        {
            while (IsSerConnected)
            {
                try
                {
                    TcpReciveData = new byte[1024];
                    int length = ns.Read(TcpReciveData, 0, TcpReciveData.Length);
                    if (length <= 0) { break; }

                    for (int i = 0; i < 100; i++)
                    {
                        mes += i + ":" + TcpReciveData[i].ToString("X") + " ";
                    }
                    if (IsRead)
                    {
                        if (ProtocolType == Protocol.MC)
                        {
                            this.Invoke(new Action(() =>
                        {
                            string dev = txbRDev.Text.Substring(0, 1);
                            int idx = Convert.ToInt32(txbRDev.Text.Substring(1, txbRDev.Text.Length - 1));
                        }));
                        }
                        //Modbus TCP/IP
                        if (ProtocolType == Protocol.Modbus)
                        {
                            short rValue = (short)(TcpReciveData[9] << 8 | TcpReciveData[10]);
                            this.Invoke(new Action(() =>
                            {
                                txbRVal.Text = rValue.ToString();
                            }));
                        }
                        IsRead = false;
                    }
                }
                catch
                {
                    IsSerConnected = false;
                    break;
                }
            }
        }
        private void ComPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string recData = comPort.ReadExisting();
            if (recData == null) return;
            if (!(recData.Contains('\0') && recData.Contains('\r')))
            {
                sttMes = "Data loss from Com";
                WriteToPLC(0);
                return;
            }
            sttMes = " ";
            string dataRecv = "";
            for (int i = 0; i < recData.Length; i++)
            {
                if (recData[i] == '\r') break;
                if (recData[i] == '\0') continue;
                dataRecv += recData[i];
            }
            //dataRecv = dataRecv.Substring(1, recData.Length - 2);
            try
            {
                string[] data = dataRecv.Split(',');
                objDetect = data[0];
                score = float.Parse(data[1]);
                x1 = Convert.ToInt32(data[2]);
                y1 = Convert.ToInt32(data[3]);
                x2 = Convert.ToInt32(data[4]);
                y2 = Convert.ToInt32(data[5]);
            }
            catch { }
            if (!(objDetect == "Empty")) WriteToPLC(1);
            else WriteToPLC(0);
            byte[] rep = Encoding.UTF8.GetBytes("OK\r\n");
            comPort.Write(rep, 0, rep.Length);
            ShowData("From COM: " + dataRecv);
        }
        private void WriteToPLC(int nMode)
        {
            if (nMode == 1)
            {
                short[] sendData = new short[6];
                sendData[0] = 99;
                sendData[1] = (short)(objDetect == "person" ? 1 : objDetect == "cell phone" ? 2 : 0);
                sendData[2] = (short)x1;
                sendData[3] = (short)y1;
                sendData[4] = (short)x2;
                sendData[5] = (short)y1;
                if (ProtocolType == Protocol.Modbus)
                    WriteMulDeviceS71200(1, 0, 6, sendData);
                else if (ProtocolType == Protocol.MC)
                    WriteMulDeviceBlockD16(0, 6, sendData);
            }
            else
            {
                short[] sendData = new short[6];
                sendData[0] = 0;
                sendData[1] = 0;
                sendData[2] = 0;
                sendData[3] = 0;
                sendData[4] = 0;
                sendData[5] = 0;

                if (ProtocolType == Protocol.Modbus)
                    WriteMulDeviceS71200(1, 0, 6, sendData);
                else if (ProtocolType == Protocol.MC)
                    WriteMulDeviceBlockD16(0, 6, sendData);
            }
        }
        private void frmTimer_Tick(object sender, EventArgs e)
        {
            if (tcpClient != null)
            {
                lbSerStt.Text = tcpClient.Connected ? "Server Connect" : "Server Disconnect";
                lbSerStt.ForeColor = tcpClient.Connected ? Color.Green : Color.Red;
                IsSerConnected = false;
            }
            else
            {
                lbSerStt.Text = "Server Disconnect";
                lbSerStt.ForeColor = Color.Red;
            }

            btnTcpOpen.Text = IsSerConnected ? "Server Connect" : "Server Disconnect";
            btnTcpOpen.BackColor = IsSerConnected ? Color.Green : SystemColors.Control;
            lbCOMStt.Text = IsComConnected ? "COM Connect" : "COM Disconnect";
            lbCOMStt.ForeColor = IsComConnected ? Color.Green : Color.Red;
            btnComOpen.Text = IsComConnected ? "COM Connect" : "COM Disconnect";
            btnComOpen.BackColor = IsComConnected ? Color.Green : SystemColors.Control;
            btnAllOpen.Text = IsSerConnected && IsComConnected ? "Disconnect" : "Connect";
            btnAllOpen.BackColor = IsSerConnected && IsComConnected ? Color.Green : SystemColors.Control;
            button1.BackColor = IsVisionStart? Color.Green : SystemColors.Control;
            button1.Text = IsVisionStart ? "Stop" : "Start";

            txbVisObject.Text = objDetect;
            txbVisScore.Text = score.ToString();
            txbVisX1.Text = x1.ToString();
            txbVisY1.Text = y1.ToString();
            txbVisX2.Text = x2.ToString();
            txbVisY2.Text = y2.ToString();

            if (sttMes != "")
            {
                txbStatus.Text = sttMes;
                sttMes = "";
            }
        }
        #endregion
    }
}

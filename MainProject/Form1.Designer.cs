namespace MainProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            btnComOpen = new Button();
            cbbStopBits = new ComboBox();
            cbbDataBits = new ComboBox();
            cbbParityBits = new ComboBox();
            cbbBaudRate = new ComboBox();
            cbbPortName = new ComboBox();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txbModbusPort = new TextBox();
            txbModbusIP = new TextBox();
            label29 = new Label();
            label30 = new Label();
            btnTcpOpen = new Button();
            txbSerPort = new TextBox();
            txbSerIP = new TextBox();
            label6 = new Label();
            label5 = new Label();
            lsbShowData = new ListBox();
            groupBox3 = new GroupBox();
            label28 = new Label();
            txbWLength = new TextBox();
            label27 = new Label();
            label26 = new Label();
            txbWDev = new TextBox();
            txbRDev = new TextBox();
            label11 = new Label();
            btnPlcWrite = new Button();
            btnPlcRead = new Button();
            txbRVal = new TextBox();
            label12 = new Label();
            txbWVal = new TextBox();
            btnClear = new Button();
            tabControl1 = new TabControl();
            tbMain = new TabPage();
            pictureBox1 = new PictureBox();
            label18 = new Label();
            btnSaveLog = new Button();
            checkBox1 = new CheckBox();
            groupBox4 = new GroupBox();
            txbVisScore = new TextBox();
            label24 = new Label();
            txbVisY2 = new TextBox();
            txbVisX2 = new TextBox();
            txbVisY1 = new TextBox();
            txbVisX1 = new TextBox();
            txbVisObject = new TextBox();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            lbSerStt = new Label();
            lbCOMStt = new Label();
            btnAllOpen = new Button();
            tbManual = new TabPage();
            groupBox5 = new GroupBox();
            txbComSendData = new TextBox();
            label8 = new Label();
            txbTCPSendData = new TextBox();
            label9 = new Label();
            btnComSend = new Button();
            btnTcpSend = new Button();
            tbSetting = new TabPage();
            btnSaveConfig = new Button();
            btnLoadConfig = new Button();
            cbbProtocol = new ComboBox();
            label10 = new Label();
            txbStatus = new TextBox();
            label17 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label31 = new Label();
            label15 = new Label();
            label13 = new Label();
            label16 = new Label();
            label14 = new Label();
            frmTimer = new System.Windows.Forms.Timer(components);
            panel3 = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            tabControl1.SuspendLayout();
            tbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox4.SuspendLayout();
            panel2.SuspendLayout();
            tbManual.SuspendLayout();
            groupBox5.SuspendLayout();
            tbSetting.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnComOpen);
            groupBox1.Controls.Add(cbbStopBits);
            groupBox1.Controls.Add(cbbDataBits);
            groupBox1.Controls.Add(cbbParityBits);
            groupBox1.Controls.Add(cbbBaudRate);
            groupBox1.Controls.Add(cbbPortName);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(266, 245);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "SerialCOM";
            // 
            // btnComOpen
            // 
            btnComOpen.Location = new Point(67, 211);
            btnComOpen.Name = "btnComOpen";
            btnComOpen.Size = new Size(113, 28);
            btnComOpen.TabIndex = 9;
            btnComOpen.Text = "Open";
            btnComOpen.UseVisualStyleBackColor = true;
            btnComOpen.Click += btnComOpen_Click;
            // 
            // cbbStopBits
            // 
            cbbStopBits.FormattingEnabled = true;
            cbbStopBits.Items.AddRange(new object[] { "1", "2", "1.5" });
            cbbStopBits.Location = new Point(106, 140);
            cbbStopBits.Name = "cbbStopBits";
            cbbStopBits.Size = new Size(144, 28);
            cbbStopBits.TabIndex = 8;
            // 
            // cbbDataBits
            // 
            cbbDataBits.FormattingEnabled = true;
            cbbDataBits.Items.AddRange(new object[] { "5", "6", "7", "8" });
            cbbDataBits.Location = new Point(106, 110);
            cbbDataBits.Name = "cbbDataBits";
            cbbDataBits.Size = new Size(144, 28);
            cbbDataBits.TabIndex = 8;
            // 
            // cbbParityBits
            // 
            cbbParityBits.FormattingEnabled = true;
            cbbParityBits.Items.AddRange(new object[] { "None", "Odd", "Even", "Mark", "Space" });
            cbbParityBits.Location = new Point(106, 80);
            cbbParityBits.Name = "cbbParityBits";
            cbbParityBits.Size = new Size(144, 28);
            cbbParityBits.TabIndex = 8;
            // 
            // cbbBaudRate
            // 
            cbbBaudRate.FormattingEnabled = true;
            cbbBaudRate.Location = new Point(106, 50);
            cbbBaudRate.Name = "cbbBaudRate";
            cbbBaudRate.Size = new Size(144, 28);
            cbbBaudRate.TabIndex = 8;
            // 
            // cbbPortName
            // 
            cbbPortName.FormattingEnabled = true;
            cbbPortName.Location = new Point(106, 20);
            cbbPortName.Name = "cbbPortName";
            cbbPortName.Size = new Size(144, 28);
            cbbPortName.Sorted = true;
            cbbPortName.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 143);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 6;
            label7.Text = "Stop Bits:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 53);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 3;
            label4.Text = "Baud Rate:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 83);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 2;
            label3.Text = "Parity Bits:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 113);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Data Bits:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 23);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Port Name:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txbModbusPort);
            groupBox2.Controls.Add(txbModbusIP);
            groupBox2.Controls.Add(label29);
            groupBox2.Controls.Add(label30);
            groupBox2.Controls.Add(btnTcpOpen);
            groupBox2.Controls.Add(txbSerPort);
            groupBox2.Controls.Add(txbSerIP);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(278, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(266, 245);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "TCP/IP Client";
            // 
            // txbModbusPort
            // 
            txbModbusPort.Location = new Point(107, 145);
            txbModbusPort.Name = "txbModbusPort";
            txbModbusPort.Size = new Size(77, 27);
            txbModbusPort.TabIndex = 14;
            txbModbusPort.Text = "502";
            // 
            // txbModbusIP
            // 
            txbModbusIP.Location = new Point(107, 111);
            txbModbusIP.Name = "txbModbusIP";
            txbModbusIP.Size = new Size(144, 27);
            txbModbusIP.TabIndex = 13;
            txbModbusIP.Text = "192.168.1.13";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(5, 148);
            label29.Name = "label29";
            label29.Size = new Size(96, 20);
            label29.TabIndex = 12;
            label29.Text = "Modbus Port:";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(5, 114);
            label30.Name = "label30";
            label30.Size = new Size(103, 20);
            label30.TabIndex = 11;
            label30.Text = "Modbus Addr:";
            // 
            // btnTcpOpen
            // 
            btnTcpOpen.Location = new Point(84, 211);
            btnTcpOpen.Name = "btnTcpOpen";
            btnTcpOpen.Size = new Size(100, 28);
            btnTcpOpen.TabIndex = 10;
            btnTcpOpen.Text = "Open";
            btnTcpOpen.UseVisualStyleBackColor = true;
            btnTcpOpen.Click += btnTcpOpen_Click;
            // 
            // txbSerPort
            // 
            txbSerPort.Location = new Point(107, 54);
            txbSerPort.Name = "txbSerPort";
            txbSerPort.Size = new Size(77, 27);
            txbSerPort.TabIndex = 3;
            txbSerPort.Text = "1300";
            // 
            // txbSerIP
            // 
            txbSerIP.Location = new Point(107, 20);
            txbSerIP.Name = "txbSerIP";
            txbSerIP.Size = new Size(144, 27);
            txbSerIP.TabIndex = 2;
            txbSerIP.Text = "192.168.1.39";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 57);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 1;
            label6.Text = "MC Port:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 23);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 0;
            label5.Text = "MC Address:";
            // 
            // lsbShowData
            // 
            lsbShowData.FormattingEnabled = true;
            lsbShowData.HorizontalScrollbar = true;
            lsbShowData.ItemHeight = 20;
            lsbShowData.Location = new Point(369, 31);
            lsbShowData.Name = "lsbShowData";
            lsbShowData.ScrollAlwaysVisible = true;
            lsbShowData.Size = new Size(409, 424);
            lsbShowData.TabIndex = 12;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label28);
            groupBox3.Controls.Add(txbWLength);
            groupBox3.Controls.Add(label27);
            groupBox3.Controls.Add(label26);
            groupBox3.Controls.Add(txbWDev);
            groupBox3.Controls.Add(txbRDev);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(btnPlcWrite);
            groupBox3.Controls.Add(btnPlcRead);
            groupBox3.Controls.Add(txbRVal);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(txbWVal);
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(775, 138);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "PLC";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(245, 23);
            label28.Name = "label28";
            label28.Size = new Size(54, 20);
            label28.TabIndex = 31;
            label28.Text = "Length";
            // 
            // txbWLength
            // 
            txbWLength.Location = new Point(236, 49);
            txbWLength.Name = "txbWLength";
            txbWLength.Size = new Size(72, 27);
            txbWLength.TabIndex = 29;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(158, 23);
            label27.Name = "label27";
            label27.Size = new Size(45, 20);
            label27.TabIndex = 28;
            label27.Text = "Value";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(63, 23);
            label26.Name = "label26";
            label26.Size = new Size(59, 20);
            label26.TabIndex = 27;
            label26.Text = "Dev No";
            // 
            // txbWDev
            // 
            txbWDev.Location = new Point(56, 49);
            txbWDev.Name = "txbWDev";
            txbWDev.Size = new Size(72, 27);
            txbWDev.TabIndex = 16;
            // 
            // txbRDev
            // 
            txbRDev.Location = new Point(56, 86);
            txbRDev.Name = "txbRDev";
            txbRDev.Size = new Size(72, 27);
            txbRDev.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(8, 52);
            label11.Name = "label11";
            label11.Size = new Size(45, 20);
            label11.TabIndex = 16;
            label11.Text = "Write";
            // 
            // btnPlcWrite
            // 
            btnPlcWrite.Location = new Point(326, 48);
            btnPlcWrite.Name = "btnPlcWrite";
            btnPlcWrite.Size = new Size(61, 28);
            btnPlcWrite.TabIndex = 10;
            btnPlcWrite.Text = "Write";
            btnPlcWrite.UseVisualStyleBackColor = true;
            btnPlcWrite.Click += PLCWrite_Click;
            // 
            // btnPlcRead
            // 
            btnPlcRead.Location = new Point(326, 86);
            btnPlcRead.Name = "btnPlcRead";
            btnPlcRead.Size = new Size(61, 28);
            btnPlcRead.TabIndex = 17;
            btnPlcRead.Text = "Read";
            btnPlcRead.UseVisualStyleBackColor = true;
            btnPlcRead.Click += btnPlcRead_Click;
            // 
            // txbRVal
            // 
            txbRVal.Location = new Point(146, 86);
            txbRVal.Name = "txbRVal";
            txbRVal.ReadOnly = true;
            txbRVal.Size = new Size(72, 27);
            txbRVal.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(8, 89);
            label12.Name = "label12";
            label12.Size = new Size(43, 20);
            label12.TabIndex = 18;
            label12.Text = "Read";
            // 
            // txbWVal
            // 
            txbWVal.Location = new Point(146, 49);
            txbWVal.Name = "txbWVal";
            txbWVal.Size = new Size(72, 27);
            txbWVal.TabIndex = 17;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(369, 458);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 27);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbMain);
            tabControl1.Controls.Add(tbManual);
            tabControl1.Controls.Add(tbSetting);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 134);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(792, 523);
            tabControl1.TabIndex = 17;
            // 
            // tbMain
            // 
            tbMain.Controls.Add(pictureBox1);
            tbMain.Controls.Add(label18);
            tbMain.Controls.Add(btnSaveLog);
            tbMain.Controls.Add(checkBox1);
            tbMain.Controls.Add(groupBox4);
            tbMain.Controls.Add(panel2);
            tbMain.Controls.Add(lsbShowData);
            tbMain.Controls.Add(btnClear);
            tbMain.Location = new Point(4, 29);
            tbMain.Name = "tbMain";
            tbMain.Padding = new Padding(3);
            tbMain.Size = new Size(784, 490);
            tbMain.TabIndex = 0;
            tbMain.Text = "Main";
            tbMain.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 231);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(358, 253);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(369, 9);
            label18.Name = "label18";
            label18.Size = new Size(150, 20);
            label18.TabIndex = 25;
            label18.Text = "Communication Data";
            // 
            // btnSaveLog
            // 
            btnSaveLog.Location = new Point(684, 458);
            btnSaveLog.Name = "btnSaveLog";
            btnSaveLog.Size = new Size(94, 27);
            btnSaveLog.TabIndex = 23;
            btnSaveLog.Text = "Save";
            btnSaveLog.UseVisualStyleBackColor = true;
            btnSaveLog.Visible = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(585, 460);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(93, 24);
            checkBox1.TabIndex = 22;
            checkBox1.Text = "ByteShow";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Visible = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txbVisScore);
            groupBox4.Controls.Add(label24);
            groupBox4.Controls.Add(txbVisY2);
            groupBox4.Controls.Add(txbVisX2);
            groupBox4.Controls.Add(txbVisY1);
            groupBox4.Controls.Add(txbVisX1);
            groupBox4.Controls.Add(txbVisObject);
            groupBox4.Controls.Add(label23);
            groupBox4.Controls.Add(label22);
            groupBox4.Controls.Add(label21);
            groupBox4.Controls.Add(label20);
            groupBox4.Controls.Add(label19);
            groupBox4.Location = new Point(128, 9);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(236, 211);
            groupBox4.TabIndex = 21;
            groupBox4.TabStop = false;
            groupBox4.Text = "Data From Vision";
            // 
            // txbVisScore
            // 
            txbVisScore.Location = new Point(67, 55);
            txbVisScore.Name = "txbVisScore";
            txbVisScore.ReadOnly = true;
            txbVisScore.Size = new Size(159, 27);
            txbVisScore.TabIndex = 29;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(13, 58);
            label24.Name = "label24";
            label24.Size = new Size(49, 20);
            label24.TabIndex = 28;
            label24.Text = "Score:";
            // 
            // txbVisY2
            // 
            txbVisY2.Location = new Point(67, 173);
            txbVisY2.Name = "txbVisY2";
            txbVisY2.ReadOnly = true;
            txbVisY2.Size = new Size(159, 27);
            txbVisY2.TabIndex = 27;
            // 
            // txbVisX2
            // 
            txbVisX2.Location = new Point(67, 144);
            txbVisX2.Name = "txbVisX2";
            txbVisX2.ReadOnly = true;
            txbVisX2.Size = new Size(159, 27);
            txbVisX2.TabIndex = 27;
            // 
            // txbVisY1
            // 
            txbVisY1.Location = new Point(67, 115);
            txbVisY1.Name = "txbVisY1";
            txbVisY1.ReadOnly = true;
            txbVisY1.Size = new Size(159, 27);
            txbVisY1.TabIndex = 27;
            // 
            // txbVisX1
            // 
            txbVisX1.Location = new Point(68, 86);
            txbVisX1.Name = "txbVisX1";
            txbVisX1.ReadOnly = true;
            txbVisX1.Size = new Size(159, 27);
            txbVisX1.TabIndex = 27;
            // 
            // txbVisObject
            // 
            txbVisObject.Location = new Point(68, 24);
            txbVisObject.Name = "txbVisObject";
            txbVisObject.ReadOnly = true;
            txbVisObject.Size = new Size(159, 27);
            txbVisObject.TabIndex = 27;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(33, 176);
            label23.Name = "label23";
            label23.Size = new Size(28, 20);
            label23.TabIndex = 26;
            label23.Text = "Y2:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(33, 118);
            label22.Name = "label22";
            label22.Size = new Size(28, 20);
            label22.TabIndex = 25;
            label22.Text = "Y1:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(33, 147);
            label21.Name = "label21";
            label21.Size = new Size(29, 20);
            label21.TabIndex = 24;
            label21.Text = "X2:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(33, 89);
            label20.Name = "label20";
            label20.Size = new Size(29, 20);
            label20.TabIndex = 23;
            label20.Text = "X1:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(6, 27);
            label19.Name = "label19";
            label19.Size = new Size(56, 20);
            label19.TabIndex = 22;
            label19.Text = "Object:";
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(lbSerStt);
            panel2.Controls.Add(lbCOMStt);
            panel2.Controls.Add(btnAllOpen);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(120, 484);
            panel2.TabIndex = 13;
            // 
            // button2
            // 
            button2.Location = new Point(4, 165);
            button2.Name = "button2";
            button2.Size = new Size(110, 42);
            button2.TabIndex = 17;
            button2.Text = "Alarm Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(4, 117);
            button1.Name = "button1";
            button1.Size = new Size(110, 42);
            button1.TabIndex = 16;
            button1.Text = "Vision Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnVisStart_Click;
            // 
            // lbSerStt
            // 
            lbSerStt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbSerStt.ForeColor = Color.Red;
            lbSerStt.Location = new Point(3, 88);
            lbSerStt.Name = "lbSerStt";
            lbSerStt.Size = new Size(110, 20);
            lbSerStt.TabIndex = 15;
            lbSerStt.Text = "Server Disconnect";
            lbSerStt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbCOMStt
            // 
            lbCOMStt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbCOMStt.ForeColor = Color.Red;
            lbCOMStt.Location = new Point(3, 68);
            lbCOMStt.Name = "lbCOMStt";
            lbCOMStt.Size = new Size(110, 20);
            lbCOMStt.TabIndex = 14;
            lbCOMStt.Text = "COM Disconnect";
            lbCOMStt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAllOpen
            // 
            btnAllOpen.Location = new Point(4, 6);
            btnAllOpen.Name = "btnAllOpen";
            btnAllOpen.Size = new Size(110, 57);
            btnAllOpen.TabIndex = 14;
            btnAllOpen.Text = "Open Connection";
            btnAllOpen.UseVisualStyleBackColor = true;
            btnAllOpen.Click += OpenConnection_Click;
            // 
            // tbManual
            // 
            tbManual.Controls.Add(groupBox5);
            tbManual.Controls.Add(groupBox3);
            tbManual.Location = new Point(4, 29);
            tbManual.Name = "tbManual";
            tbManual.Size = new Size(784, 490);
            tbManual.TabIndex = 2;
            tbManual.Text = "Manual";
            tbManual.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txbComSendData);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(txbTCPSendData);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(btnComSend);
            groupBox5.Controls.Add(btnTcpSend);
            groupBox5.Location = new Point(3, 157);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(775, 121);
            groupBox5.TabIndex = 24;
            groupBox5.TabStop = false;
            groupBox5.Text = "TCP/IP";
            // 
            // txbComSendData
            // 
            txbComSendData.Location = new Point(128, 26);
            txbComSendData.Name = "txbComSendData";
            txbComSendData.Size = new Size(259, 27);
            txbComSendData.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 29);
            label8.Name = "label8";
            label8.Size = new Size(115, 20);
            label8.TabIndex = 21;
            label8.Text = "COM Send Data";
            // 
            // txbTCPSendData
            // 
            txbTCPSendData.Location = new Point(128, 64);
            txbTCPSendData.Name = "txbTCPSendData";
            txbTCPSendData.Size = new Size(259, 27);
            txbTCPSendData.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 67);
            label9.Name = "label9";
            label9.Size = new Size(106, 20);
            label9.TabIndex = 22;
            label9.Text = "TCP Send Data";
            // 
            // btnComSend
            // 
            btnComSend.Location = new Point(393, 25);
            btnComSend.Name = "btnComSend";
            btnComSend.Size = new Size(94, 28);
            btnComSend.TabIndex = 18;
            btnComSend.Text = "Send";
            btnComSend.UseVisualStyleBackColor = true;
            btnComSend.Click += btnComSend_Click;
            // 
            // btnTcpSend
            // 
            btnTcpSend.Location = new Point(393, 63);
            btnTcpSend.Name = "btnTcpSend";
            btnTcpSend.Size = new Size(94, 28);
            btnTcpSend.TabIndex = 20;
            btnTcpSend.Text = "Send";
            btnTcpSend.UseVisualStyleBackColor = true;
            btnTcpSend.Click += btnTcpSend_Click;
            // 
            // tbSetting
            // 
            tbSetting.Controls.Add(btnSaveConfig);
            tbSetting.Controls.Add(btnLoadConfig);
            tbSetting.Controls.Add(groupBox1);
            tbSetting.Controls.Add(groupBox2);
            tbSetting.Location = new Point(4, 29);
            tbSetting.Name = "tbSetting";
            tbSetting.Padding = new Padding(3);
            tbSetting.Size = new Size(784, 490);
            tbSetting.TabIndex = 1;
            tbSetting.Text = "Setting";
            tbSetting.UseVisualStyleBackColor = true;
            // 
            // btnSaveConfig
            // 
            btnSaveConfig.Location = new Point(609, 86);
            btnSaveConfig.Name = "btnSaveConfig";
            btnSaveConfig.Size = new Size(109, 44);
            btnSaveConfig.TabIndex = 11;
            btnSaveConfig.Text = "Save";
            btnSaveConfig.UseVisualStyleBackColor = true;
            btnSaveConfig.Click += btnSaveConfig_Click;
            // 
            // btnLoadConfig
            // 
            btnLoadConfig.Location = new Point(609, 21);
            btnLoadConfig.Name = "btnLoadConfig";
            btnLoadConfig.Size = new Size(109, 44);
            btnLoadConfig.TabIndex = 10;
            btnLoadConfig.Text = "Load";
            btnLoadConfig.UseVisualStyleBackColor = true;
            btnLoadConfig.Click += btnLoadConfig_Click;
            // 
            // cbbProtocol
            // 
            cbbProtocol.FormattingEnabled = true;
            cbbProtocol.Items.AddRange(new object[] { "MC Protocol", "Modbus TCP/IP" });
            cbbProtocol.Location = new Point(87, 11);
            cbbProtocol.Name = "cbbProtocol";
            cbbProtocol.Size = new Size(135, 28);
            cbbProtocol.TabIndex = 24;
            cbbProtocol.SelectedIndexChanged += cbbProtocol_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 14);
            label10.Name = "label10";
            label10.Size = new Size(68, 20);
            label10.TabIndex = 16;
            label10.Text = "Protocol:";
            // 
            // txbStatus
            // 
            txbStatus.Location = new Point(306, 11);
            txbStatus.Name = "txbStatus";
            txbStatus.ReadOnly = true;
            txbStatus.Size = new Size(474, 27);
            txbStatus.TabIndex = 15;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(237, 14);
            label17.Name = "label17";
            label17.Size = new Size(70, 20);
            label17.TabIndex = 14;
            label17.Text = "Message:";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label31);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label14);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(792, 81);
            panel1.TabIndex = 18;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.c_sharp;
            pictureBox2.Location = new Point(705, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 60);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label31.ForeColor = Color.MediumBlue;
            label31.Location = new Point(275, 13);
            label31.Name = "label31";
            label31.Size = new Size(418, 54);
            label31.TabIndex = 7;
            label31.Text = "MFC - WPF UET 2023";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(77, 47);
            label15.Name = "label15";
            label15.Size = new Size(178, 21);
            label15.TabIndex = 6;
            label15.Text = "Hội | Nam | Sơn | Huỳnh";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(6, 47);
            label13.Name = "label13";
            label13.Size = new Size(72, 21);
            label13.TabIndex = 5;
            label13.Text = "Member:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(77, 14);
            label16.Name = "label16";
            label16.Size = new Size(67, 21);
            label16.TabIndex = 3;
            label16.Text = "Nhóm 3";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(6, 14);
            label14.Name = "label14";
            label14.Size = new Size(49, 21);
            label14.TabIndex = 1;
            label14.Text = "Team:";
            // 
            // frmTimer
            // 
            frmTimer.Enabled = true;
            frmTimer.Tick += frmTimer_Tick;
            // 
            // panel3
            // 
            panel3.Controls.Add(cbbProtocol);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(txbStatus);
            panel3.Controls.Add(label17);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 81);
            panel3.Name = "panel3";
            panel3.Size = new Size(792, 50);
            panel3.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 657);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Main Project";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabControl1.ResumeLayout(false);
            tbMain.ResumeLayout(false);
            tbMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel2.ResumeLayout(false);
            tbManual.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            tbSetting.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnComOpen;
        private ComboBox cbbStopBits;
        private ComboBox cbbDataBits;
        private ComboBox cbbParityBits;
        private ComboBox cbbBaudRate;
        private ComboBox cbbPortName;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnTcpOpen;
        private TextBox txbSerPort;
        private TextBox txbSerIP;
        private Label label6;
        private Label label5;
        private ListBox lsbShowData;
        private TextBox txbStatus;
        private GroupBox groupBox3;
        private Button btnPlcRead;
        private TextBox txbRVal;
        private Label label12;
        private TextBox txbRDev;
        private TextBox txbWVal;
        private Label label11;
        private TextBox txbWDev;
        private Button btnPlcWrite;
        private Button btnClear;
        private TabControl tabControl1;
        private TabPage tbMain;
        private TabPage tbSetting;
        private Panel panel2;
        private Button btnAllOpen;
        private TabPage tbManual;
        private Label label8;
        private Label label9;
        private TextBox txbComSendData;
        private Button btnTcpSend;
        private Button btnComSend;
        private TextBox txbTCPSendData;
        private Panel panel1;
        private Label lbSerStt;
        private Label lbCOMStt;
        private Label label14;
        private Label label16;
        private System.Windows.Forms.Timer frmTimer;
        private Label label17;
        private Label label10;
        private GroupBox groupBox4;
        private TextBox txbVisY2;
        private TextBox txbVisX2;
        private TextBox txbVisY1;
        private TextBox txbVisX1;
        private TextBox txbVisObject;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private CheckBox checkBox1;
        private ComboBox cbbProtocol;
        private Button btnSaveLog;
        private Label label18;
        private TextBox txbVisScore;
        private Label label24;
        private PictureBox pictureBox1;
        private Label label26;
        private GroupBox groupBox5;
        private Label label27;
        private Label label28;
        private TextBox txbWLength;
        private Button button1;
        private TextBox txbModbusPort;
        private TextBox txbModbusIP;
        private Label label29;
        private Label label30;
        private Panel panel3;
        private Label label31;
        private Label label15;
        private Label label13;
        private PictureBox pictureBox2;
        private Button btnSaveConfig;
        private Button btnLoadConfig;
        private Button button2;
    }
}
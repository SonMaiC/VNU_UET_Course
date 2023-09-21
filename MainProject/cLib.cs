using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    public enum Protocol
    {
        MCProtocol,
        ModbusTCPIP,
        Serial
    }

    public enum MosbusFunction
    {
        ReadCoil = 0x01,
        ReadHoldingRegister = 0x03,
        ReadInputRegister = 0x04,
        WriteSingleCoil = 0x05,
        WriteSingleRegister = 0x06,
        WriteMultiRegister = 0x16
    }

    public class INIFile
    {
        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder refVal, int size, string path);

        [DllImport("kernel32.dll")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string path);

        private string path;

        public INIFile(string nPath)
        {
            path = nPath;
        }

        public void SetData(String Section, String key, int DataValue)
        {
            WritePrivateProfileString(Section, key, DataValue.ToString(), path);
        }
        public void SetData(String Section, String key, double DataValue)
        {
            WritePrivateProfileString(Section, key, DataValue.ToString(), path);
        }
        public void SetData(String Section, String key, string DataValue)
        {
            WritePrivateProfileString(Section, key, DataValue, path);
        }
        public void SetData(String Section, String key, bool DataValue)
        {
            WritePrivateProfileString(Section, key, DataValue.ToString(), path);
        }

        public int GetIData(String Section, String Key)
        {
            StringBuilder temp = new StringBuilder(80);
            string temp_return;
            int i = GetPrivateProfileString(Section, Key, "0", temp, 80, path);
            temp_return = temp.ToString();
            return Convert.ToInt32(temp_return);
        }
        public double GetFData(String Section, String Key)
        {
            StringBuilder temp = new StringBuilder(80);
            string temp_return;
            int i = GetPrivateProfileString(Section, Key, "0", temp, 80, path);
            temp_return = temp.ToString();
            return Convert.ToDouble(temp_return);
        }
        public String GetSData(String Section, String Key)
        {
            StringBuilder temp = new StringBuilder(80);
            int i = GetPrivateProfileString(Section, Key, " ", temp, 80, path);
            return temp.ToString();
        }
        public bool GetBData(String Section, String Key)
        {
            bool Ret;
            StringBuilder temp = new StringBuilder(80);
            int i = GetPrivateProfileString(Section, Key, "false", temp, 80, path);
            bool.TryParse(temp.ToString(), out Ret);
            return Ret;
        }
    }
}

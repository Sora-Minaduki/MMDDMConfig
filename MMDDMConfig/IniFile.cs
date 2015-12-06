using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace MMDDMConfig
{
    public class IniFile
    {
        [DllImport("KERNEL32.DLL")]
        public static extern int GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);

        [DllImport("KERNEL32.DLL")]
        public static extern int WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);

        private string IniPath;

        public IniFile(string filepath)
        {
            IniPath = filepath;
        }

        public string this[string section, string key]
        {
            set
            {
                WritePrivateProfileString(section, key, value, IniPath);
            }
            get
            {
                StringBuilder sb = new StringBuilder(1024);
                GetPrivateProfileString(section, key, string.Empty, sb, sb.Capacity, IniPath);
                return sb.ToString();
            }
        }
    }
}
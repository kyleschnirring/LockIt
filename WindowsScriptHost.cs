using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.IO;
using System.Security.Principal;

namespace LockIt
{
    class WindowsScriptHost
    {
        public static void DisableScriptHost()
        {
            Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows Script Host\\Settings", true).CreateSubKey("Enabled");
            Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows Script Host\\Settings", true).SetValue("Enabled", 0, RegistryValueKind.DWord);
        }

        public static void EnableScriptHost()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows Script Host\\Settings", true))
            {
                key.SetValue("Enabled", 1, RegistryValueKind.DWord);
                key.Close();

            }
        }
    }
}

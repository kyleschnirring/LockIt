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
    class uac
    {
        public static void Disableuac()
        {
            using (RegistryKey uackey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", true))
            {
                uackey.SetValue("ConsentPromptBehaviorAdmin", 5, RegistryValueKind.DWord);
                uackey.Close();
            }

            using (RegistryKey uackey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", true))
            {
                uackey.SetValue("ConsentPromptBehaviorUser", 3, RegistryValueKind.DWord);
                uackey.Close();
            }


        }

        public static void Enableuac()
        {
            using (RegistryKey uackey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", true))
            {
                uackey.SetValue("EnableLUA", 1, RegistryValueKind.DWord);
                uackey.Close();
            }

            using (RegistryKey uackey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", true))
            {
                uackey.SetValue("ConsentPromptBehaviorAdmin", 1, RegistryValueKind.DWord);
                uackey.Close();
            }

            using (RegistryKey uackey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", true))
            {
                uackey.SetValue("ConsentPromptBehaviorUser", 1, RegistryValueKind.DWord);
                uackey.Close();
            }

            using (RegistryKey uackey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", true))
            {
                uackey.SetValue("PromptOnSecureLaptop", 1, RegistryValueKind.DWord);
                uackey.Close();
            }

        }
    }
}

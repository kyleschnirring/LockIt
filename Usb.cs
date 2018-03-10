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
    class Usb
    {
        public static void DisableUsb()
        {
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\USBSTOR", true))
            {
                key.SetValue("Start", 4, RegistryValueKind.DWord);
                key.Close();

            }

        }

        public static void EnableUsb()
        {
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\USBSTOR", true))
            {
                key.SetValue("Start", 3, RegistryValueKind.DWord);
                key.Close();

            }
        }
    }
}

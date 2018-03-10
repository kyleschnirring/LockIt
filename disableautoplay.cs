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
    class disableautoplay
    {
        public static void DisableAutoplay()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoplayHandlers", true))

            {
                key.SetValue("DisableAutoplay", 1, RegistryValueKind.DWord);
                key.Close();
            }
        }

        public static void EnableAutoplay()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoplayHandlers", true))
            {

                key.DeleteSubKey("DisableAutoplay", false);
                key.Close();

            }

        }

        public static void DisableAutoRun()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\policies\\Explorer\\NoDriveTypeAutorun", true))
            {
                key.SetValue("NoDriveTypeAutoRun", 0xFF, RegistryValueKind.DWord);
                key.Close();
            }
        }

        public static void EnableAutoRun()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\policies\\Explorer\\NoDriveTypeAutorun", true))
            {
                key.DeleteSubKey("NoDriveTypeAutoRun", false);
                key.Close();
            }
        }
    }
}

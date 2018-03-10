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
    class Macros
    {
        public string[] version = { "16.0", "15.0", "14.0", "12.0" };

        public static void DisablePackager()
        {
            using (var regWord = Registry.ClassesRoot.OpenSubKey("Word.Application"))
            {
                if (regWord == null)
                {
                    Console.WriteLine("Microsoft Word is not installed");
                }
                else
                {
                    using (RegistryKey wordkey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Office\\16.0\\Word\\Security", true))
                    {

                        wordkey.SetValue("PackagerPrompt", 2, RegistryValueKind.DWord);

                    }

                    using (RegistryKey excelkey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Office\\16.0\\Excel\\Security", true))
                    {
                        excelkey.SetValue("PackagerPrompt", 2, RegistryValueKind.DWord);

                    }

                    using (RegistryKey powerkey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Office\\16.0\\PowerPoint\\Security", true))
                    {
                        powerkey.SetValue("PackagerPrompt", 2, RegistryValueKind.DWord);

                    }
                }
            }
        }

        public static void EnablePackager()
        {
            using (RegistryKey wordkey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Office\\16.0\\Word\\Security", true))
            {
                wordkey.SetValue("PackagerPrompt", 1, RegistryValueKind.DWord);

            }

            using (RegistryKey excelkey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Office\\16.0\\Excel\\Security", true))
            {
                excelkey.SetValue("PackagerPrompt", 1, RegistryValueKind.DWord);

            }

            using (RegistryKey powerkey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Office\\16.0\\PowerPoint\\Security", true))
            {
                powerkey.SetValue("PackagerPrompt", 1, RegistryValueKind.DWord);

            }
        }

        public static void DisableMacro()
        {

            using (RegistryKey wordkey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Office\\16.0\\Word\\Security", true))
            {
                wordkey.SetValue("VBAWarnings", 4, RegistryValueKind.DWord);

            }

            using (RegistryKey excelkey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Office\\16.0\\Excel\\Security", true))
            {
                excelkey.SetValue("VBAWarnings", 4, RegistryValueKind.DWord);

            }

            using (RegistryKey powerkey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Office\\16.0\\PowerPoint\\Security", true))
            {
                powerkey.SetValue("VBAWarnings", 4, RegistryValueKind.DWord);

            }
        }

        public static void EnableMacro()
        {
            using (RegistryKey wordkey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Office\\16.0\\Word\\Security", true))
            {
                wordkey.SetValue("VBAWarnings", 2, RegistryValueKind.DWord);

            }

            using (RegistryKey excelkey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Office\\16.0\\Excel\\Security", true))
            {
                excelkey.SetValue("VBAWarnings", 2, RegistryValueKind.DWord);

            }

            using (RegistryKey powerkey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Office\\16.0\\PowerPoint\\Security", true))
            {
                powerkey.SetValue("VBAWarnings", 2, RegistryValueKind.DWord);

            }
        }
    }
}

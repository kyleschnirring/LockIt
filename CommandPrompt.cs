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
    class CommandPrompt
    {
        //Disable command prompt
        public static void DisableCommandPrompt()
        {
            Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
            Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).CreateSubKey("DisallowRun");
            Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).SetValue("DisallowRun", 0x1, RegistryValueKind.DWord);


            using (RegistryKey disallowkey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\DisallowRun", true))
            {

                disallowkey.SetValue("1", "cmd.exe", RegistryValueKind.String);

                disallowkey.SetValue("2", "powershell.exe", RegistryValueKind.String);

                disallowkey.SetValue("3", "powershell_ise.exe", RegistryValueKind.String);

                disallowkey.SetValue("4", "bash.exe", RegistryValueKind.String);

                disallowkey.SetValue("5", "cscript.exe", RegistryValueKind.String);

                disallowkey.SetValue("6", "msbuild.exe", RegistryValueKind.String);

                disallowkey.SetValue("7", "regsrv32.exe", RegistryValueKind.String);

                disallowkey.SetValue("8", "certutil.exe", RegistryValueKind.String);

                disallowkey.SetValue("9", "git-bash.exe", RegistryValueKind.String);

                disallowkey.SetValue("10", "git-cmd.exe", RegistryValueKind.String);

                disallowkey.SetValue("11", "git-gui.exe", RegistryValueKind.String);

                disallowkey.SetValue("12", "mshta.exe", RegistryValueKind.String);

                disallowkey.SetValue("13", "rundll32.exe", RegistryValueKind.String);

                disallowkey.SetValue("14", "Cdb.exe", RegistryValueKind.String);

                disallowkey.SetValue("15", "Csc.exe", RegistryValueKind.String);

                disallowkey.SetValue("16", "Tracker.exe", RegistryValueKind.String);

                disallowkey.SetValue("17", "Ntsd.exe", RegistryValueKind.String);

                disallowkey.SetValue("18", "Bginfo.exe", RegistryValueKind.String);

                disallowkey.SetValue("19", "Kd.exe", RegistryValueKind.String);

                disallowkey.SetValue("20", "Rcsi.exe", RegistryValueKind.String);

                disallowkey.SetValue("21", "Dnx.exe", RegistryValueKind.String);

                disallowkey.SetValue("22", "Csi.exe", RegistryValueKind.String);

                disallowkey.SetValue("23", "Certreq.exe", RegistryValueKind.String);

                disallowkey.SetValue("24", "Dbghost.exe", RegistryValueKind.String);

                disallowkey.SetValue("25", "InstallUtil.exe", RegistryValueKind.String);

                disallowkey.SetValue("26", "Msxsl.exe", RegistryValueKind.String);

                disallowkey.SetValue("27", "Regsvcs.exe", RegistryValueKind.String);

                disallowkey.SetValue("28", "Regasm.exe", RegistryValueKind.String);

                disallowkey.SetValue("29", "MSDT.exe", RegistryValueKind.String);

                disallowkey.SetValue("30", "Dfsvc.exe", RegistryValueKind.String);

                disallowkey.SetValue("31", "IEExec.exe", RegistryValueKind.String);

                disallowkey.SetValue("32", "Control.exe", RegistryValueKind.String);

                disallowkey.SetValue("33", "CMSTP.exe", RegistryValueKind.String);

                disallowkey.SetValue("34", "Xwizard.exe", RegistryValueKind.String);

                disallowkey.SetValue("35", "Fsi.exe", RegistryValueKind.String);

                disallowkey.SetValue("36", "Obdconf.exe", RegistryValueKind.String);

                disallowkey.SetValue("37", "windbg.exe", RegistryValueKind.String);

                disallowkey.SetValue("38", "PresentationHost.exe", RegistryValueKind.String);

                disallowkey.SetValue("39", "msiexec.exe", RegistryValueKind.String);

                disallowkey.SetValue("40", "te.exe", RegistryValueKind.String);

                disallowkey.SetValue("41", "ATBroker.exe", RegistryValueKind.String);

                disallowkey.SetValue("42", "runscripthelper.exe", RegistryValueKind.String);

                disallowkey.SetValue("43", "SyncAppvPublishing.exe", RegistryValueKind.String);

                disallowkey.SetValue("44", "pcalua.exe", RegistryValueKind.String);

                disallowkey.SetValue("45", "AppVLP.exe", RegistryValueKind.String);
                disallowkey.Close();
            }
        }

        //Enable command prompt
        public static void EnableCommandPrompt()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true))
            {
                key.DeleteSubKey("DisallowRun", false);

                key.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Management;
using Microsoft.Win32;
using System.IO;



namespace LockIt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
            BitmapImage wifibmp = new BitmapImage(new Uri("pack://application:,,,/Resources/wifi.png"));
            wifiImage.Source = wifibmp;

            using (RegistryKey Key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\DisallowRun"))
                if (Key != null)
                {
                    BitmapImage bmp = new BitmapImage(new Uri("pack://application:,,,/Resources/yes.png"));
                    appImage.Source = bmp;
                    
                    
                    unappButton.Visibility = Visibility.Visible;
                    appButton.Visibility = Visibility.Hidden;
                    
                }
                else
                {
                    BitmapImage bmp = new BitmapImage(new Uri("pack://application:,,,/Resources/no.png"));
                    appImage.Source = bmp;

                    appButton.Visibility = Visibility.Visible;
                    unappButton.Visibility = Visibility.Hidden;
                }

            using (RegistryKey usb = Registry.LocalMachine.OpenSubKey(@"SYSTEM\\CurrentControlSet\\Services\\USBSTOR"))
            {
                object usbdwordvalue = usb.GetValue("Start");
                string usbdwordstring = usbdwordvalue.ToString();

                if (usbdwordstring == "3")
                {

                    BitmapImage usbbmp = new BitmapImage(new Uri("pack://application:,,,/Resources/no.png"));
                    usbImage.Source = usbbmp;

                    unlockusbButton1.Visibility = Visibility.Hidden;
                    usbButton.Visibility = Visibility.Visible;
                }
                else
                {
                    BitmapImage usbbmpno = new BitmapImage(new Uri("pack://application:,,,/Resources/yes.png"));
                    usbImage.Source = usbbmpno;
                    

                    unlockusbButton1.Visibility = Visibility.Visible;
                    usbButton.Visibility = Visibility.Hidden;

                }

            }
        }

        //Locked Buttons
        private void appButton_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bmp = new BitmapImage(new Uri("pack://application:,,,/Resources/yes.png"));
            appImage.Source = bmp;

            whatsgoingonLabel.Content = "All Applications Locked";

            CommandPrompt.DisableCommandPrompt();
            WindowsScriptHost.DisableScriptHost();
            disableautoplay.DisableAutoplay();
            //disableautoplay.DisableAutoRun();
            uac.Enableuac();
            //Macros.DisableMacro();
            //Macros.DisablePackager();
            //Ddeauto.disableddeauto();

            unappButton.Visibility = Visibility.Visible;
            appButton.Visibility = Visibility.Hidden;
        }

        private void usbButton_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage usbbmpno = new BitmapImage(new Uri("pack://application:,,,/Resources/yes.png"));
            usbImage.Source = usbbmpno;

            whatsgoingonLabel.Content = "All USB Ports Locked";

            Usb.DisableUsb();
            usbButton.Visibility = Visibility.Hidden;
            unlockusbButton1.Visibility = Visibility.Visible;
        }

        private void wifiButton_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bmp = new BitmapImage(new Uri("pack://application:,,,/Resources/nowifi.png"));
            wifiImage.Source = bmp;

            //netsh wlan delete profile name = *i = *
            Process p = new Process();
            p.StartInfo.FileName = "netsh.exe";
            p.StartInfo.Arguments = "wlan delete profile name = *";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            try
            {
                p.Start();
            }
            catch
            {
                throw;
            }

            whatsgoingonLabel.Content = "All WiFi AP's Deleted";

        }
        
        //UnLock Buttons

        private void unappButton_Click(object sender, RoutedEventArgs e)
        {

            BitmapImage bmp = new BitmapImage(new Uri("pack://application:,,,/Resources/no.png"));
            appImage.Source = bmp;

            whatsgoingonLabel.Content = "All Applications UnLocked";

            appButton.Visibility = Visibility.Visible;
            unappButton.Visibility = Visibility.Hidden;

            CommandPrompt.EnableCommandPrompt();
            disableautoplay.EnableAutoplay();
            WindowsScriptHost.EnableScriptHost();
            uac.Disableuac();

            //Macros.EnableMacro();
           // Macros.EnablePackager();
            //Ddeauto.enableddeauto();

        }

        private void unlockusbButton1_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage usbbmp = new BitmapImage(new Uri("pack://application:,,,/Resources/no.png"));
            usbImage.Source = usbbmp;

            whatsgoingonLabel.Content = "All USB Ports UnLocked";

            Usb.EnableUsb();

            usbButton.Visibility = Visibility.Visible;
            unlockusbButton1.Visibility = Visibility.Hidden;
        }
    }
}

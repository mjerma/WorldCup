using DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void ApplicationStart(object sender, StartupEventArgs e)
        {
            //Disable shutdown when the dialog closes
            Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;

            if (UserSettings.Exists())
            {
                string[] settings = UserSettings.Load();
                if (settings.Count() > 2)
                {
                    Teams mainWindow = new Teams();
                    //Re-enable normal shutdown mode.
                    Current.ShutdownMode = ShutdownMode.OnMainWindowClose;
                    Current.MainWindow = mainWindow;
                    mainWindow.Show();
                }
                else
                {
                    StartSettings startSettings = new StartSettings();

                    if (startSettings.ShowDialog() == true)
                    {
                        Teams mainWindow = new Teams();
                        //Re-enable normal shutdown mode.
                        Current.ShutdownMode = ShutdownMode.OnMainWindowClose;
                        Current.MainWindow = mainWindow;
                        mainWindow.Show();
                    }
                    else
                    {
                        Current.Shutdown(-1);
                    }
                }
            }
            else
            {
                StartSettings startSettings = new StartSettings();

                if (startSettings.ShowDialog() == true)
                {
                    Teams mainWindow = new Teams();
                    //Re-enable normal shutdown mode.
                    Current.ShutdownMode = ShutdownMode.OnMainWindowClose;
                    Current.MainWindow = mainWindow;
                    mainWindow.Show();
                }
                else
                {
                    Current.Shutdown(-1);
                }
            }
        }
    }
}

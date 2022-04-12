﻿using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (UserSettings.Exists())
            {
                Application.Run(new FavoritesForm());
            }
            else
            {
                StartSettingsForm startSettings = new StartSettingsForm();
                if (startSettings.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new FavoritesForm());
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}

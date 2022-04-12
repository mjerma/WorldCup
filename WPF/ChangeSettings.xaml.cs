﻿using DAL;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace WPF
{
    /// <summary>
    /// Interaction logic for ChangeSettings.xaml
    /// </summary>
    public partial class ChangeSettings : Window
    {
        private static string resolution;
        public ChangeSettings()
        {
            InitializeComponent();
            Load();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Load()
        {
            string[] settings = UserSettings.Load();
            if (settings[0] == "Male")
            {
                rbMale.IsChecked = true;
            }
            else
            {
                rbFemale.IsChecked = true;
            }
            if (settings[1] == "en")
            {
                rbEnglish.IsChecked = true;
            }
            else
            {
                rbCroatian.IsChecked = true;
            }
            cbResolutions.SelectedValue = settings[2];
            resolution = settings[2];
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                string gender = pnlTeamGender.Children.OfType<RadioButton>()
                 .FirstOrDefault(r => r.IsChecked.HasValue && r.IsChecked.Value).Content.ToString();

                string language = pnlLanguage.Children.OfType<RadioButton>()
                               .FirstOrDefault(n => n.IsChecked.HasValue).Content.ToString();

                switch (language)
                {
                    case "English":
                        UserSettings.Save(gender, "en", resolution);
                        break;
                    case "Croatian":
                        UserSettings.Save(gender, "hr", resolution);
                        break;
                }
                DialogResult = true;
            }
        }

        private void cbResolutions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selection = (e.Source as ComboBox).SelectedItem as ComboBoxItem;
            resolution = selection.Content.ToString();
        }
    }
}

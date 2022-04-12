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
    /// Interaction logic for PlayerStats.xaml
    /// </summary>
    public partial class PlayerDetails : Window
    {
        public ImageSource PlayerImage 
        { 
            get { return imgPlayer.Source; } 
            set { imgPlayer.Source = value; } 
        }
        public string PlayerName 
        { 
            get { return tbName.Text; } 
            set { tbName.Text = value; } 
        }
        public string PlayerShirtNumber 
        { 
            get { return tbNumber.Text; } 
            set { tbNumber.Text = value; } 
        }
        public string PlayerPosition 
        { 
            get { return tbPosition.Text; } 
            set { tbPosition.Text = value; } 
        }
        public string PlayerIsCaptain 
        { 
            get { return tbCaptain.Text; } 
            set { tbCaptain.Text = value; } 
        }
        public string PlayerGoals 
        { 
            get { return tbGoals.Text; } 
            set { tbGoals.Text = value; } 
        }
        public string PlayerYellowCards 
        { 
            get { return tbYellowCards.Text; } 
            set { tbYellowCards.Text = value; } 
        }
        public PlayerDetails()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
    }
}

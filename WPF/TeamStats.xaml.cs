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
    /// Interaction logic for TeamStats.xaml
    /// </summary>
    public partial class TeamStats : Window
    {
        public string Team 
        { 
            get { return tbTeam.Text; } 
            set { tbTeam.Text = value; } 
        }
        public string FifaCode 
        { 
            get { return tbFifaCode.Text; } 
            set { tbFifaCode.Text = value; } 
        }
        public string GamesPlayed 
        { 
            get { return tbGamesPlayed.Text; } 
            set { tbGamesPlayed.Text = value; } 
        }
        public string Wins 
        { 
            get { return tbWins.Text; } 
            set { tbWins.Text = value; } 
        }
        public string Losses 
        { 
            get { return tbLosses.Text; } 
            set { tbLosses.Text = value; } 
        }
        public string Draws 
        { 
            get { return tbDraws.Text; } 
            set { tbDraws.Text = value; } 
        }
        public string Scored 
        { 
            get { return tbScored.Text; } 
            set { tbScored.Text = value; } 
        }
        public string Recieved 
        { 
            get { return tbReceived.Text; } 
            set { tbReceived.Text = value; } 
        }
        public string Difference
        { 
            get { return tbDifference.Text; } 
            set { tbDifference.Text = value; } 
        }
        public TeamStats()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
    }
}

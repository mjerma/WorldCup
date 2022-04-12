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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF.UserControls
{
    public partial class PlayerControl : UserControl
    {
        public ImageSource PlayerImage 
        { 
            get { return imgPlayer.Source; } 
            set { imgPlayer.Source = value; } 
        }
        public string PlayerText 
        { 
            get { return tbPlayer.Text; } 
            set { tbPlayer.Text = value; } 
        }

        public string PlayerShirtNumber
        {
            get { return tbShirtNumber.Text; }
            set { tbShirtNumber.Text = value; }
        }
        public string PlayerFullName { get; set; }
        public string Position { get; set; }
        public string Captain { get; set; }
        public string Goals { get; set; }
        public string YellowCards { get; set; }

        public PlayerControl()
        {
            InitializeComponent();
        }

        private void btnPlayer_Click(object sender, RoutedEventArgs e)
        {
            PlayerDetails pd = new PlayerDetails();
            pd.PlayerImage = PlayerImage;
            pd.PlayerName = PlayerFullName;
            pd.PlayerShirtNumber = PlayerShirtNumber;
            pd.PlayerPosition = Position;
            pd.PlayerIsCaptain = Captain;
            pd.PlayerGoals = Goals;
            pd.PlayerYellowCards = YellowCards;
            pd.Show();
        }
    }
}

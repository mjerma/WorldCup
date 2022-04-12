using DAL;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsForms.UserControls
{
    public partial class PlayerControl : UserControl
    {
        public PictureBox PlayerImage 
        { 
            get { return pbPlayer; } 
            set { pbPlayer = value; } 
        }
        public string PlayerName 
        { 
            get { return lblNamePlaceholder.Text; } 
            set { lblNamePlaceholder.Text = value; } 
        }

        public int PlayerShirtNumber 
        { 
            get { return int.Parse(lblNumberPlaceholder.Text); } 
            set { lblNumberPlaceholder.Text = value.ToString(); } 
        }
        public string PlayerPostion 
        { 
            get { return lblPositionPlaceholder.Text; } 
            set { lblPositionPlaceholder.Text = value; } 
        }
        public bool IsCaptain 
        { 
            get { return bool.Parse(lblCaptainPlaceholder.Text); } 
            set { lblCaptainPlaceholder.Text = value.ToString(); } 
        }
        public bool IsFavorite
        {
            get { return pbStar.Image != null; }
            set
            {
                if (value)
                    pbStar.Image = Properties.Resources.star;
                else
                    pbStar.Image = null;
            }
        }
        public PlayerControl()
        {
            InitializeComponent();
        }

        private void miAddToFavorites_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel pnl = Application.OpenForms["FavoritesForm"].Controls["flpFavPlayers"] as FlowLayoutPanel;
            if (pnl.Controls.Count < 3)
            {
                pnl.Controls.Add(this);
                FavoritesForm.ChangeFavoritePlayer(this, true);
            }
            else
            {
                MessageBox.Show("Can't add more than 3 favorite players");
            }
        }

        private void miRemoveFromFavorites_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel pnl = Application.OpenForms["FavoritesForm"].Controls["flpAllPlayers"] as FlowLayoutPanel;
            pnl.Controls.Add(this);
            FavoritesForm.ChangeFavoritePlayer(this, false);
        }

        private void miChangePicture_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog fileDialog = new OpenFileDialog())
                {
                    fileDialog.Filter = "Picture files(*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png";

                    if (fileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string imageLocation = fileDialog.FileName;
                        pbPlayer.ImageLocation = imageLocation;

                        FavoritesForm.SavePicture(lblNamePlaceholder.Text, imageLocation);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
                MessageBox.Show("Cannot change image");
            }
        }
    }
}

using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using WindowsForms.UserControls;

namespace WindowsForms
{
    public partial class FavoritesForm : Form
    {
        private static string[] settings;
        public static List<string> favoritePlayers;
        private static string selectedTeam;
        private static List<Player> players;
        private static Dictionary<string, string> playerPictures;
        public FavoritesForm()
        {
            InitializeComponent();
            InitSettings();
            InitTeams();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void InitSettings()
        {
            try
            {
                settings = UserSettings.Load();
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(settings[1]);
                Controls.Clear();
                InitializeComponent();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }
        }

        private void InitTeams()
        {
            try
            {
                foreach (var team in Repo.GetTeams(settings[0]))
                {
                    cbTeams.DisplayMember = "Text";
                    cbTeams.ValueMember = "Value";
                    cbTeams.Items.Add(new { Text = team.Country + " (" + team.FifaCode + ")", Value = team.FifaCode });
                }
                UserFavorites.CreateTeamFile();
                string favTeam = UserFavorites.ReadTeam();
                if (favTeam != "")
                {
                    int favTeamIndex = cbTeams.FindStringExact(favTeam);
                    cbTeams.SelectedIndex = favTeamIndex;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
                MessageBox.Show(ex.Message);
            }
        }

        private void InitPlayers()
        {
            try
            {
                UserFavorites.CreatePlayersFile();
                favoritePlayers = UserFavorites.ReadPlayers();
                players = Repo.GetPlayers(settings[0], selectedTeam);
                Repo.CreatePicturesFile();
                playerPictures = Repo.LoadPlayerPictures();

                foreach (var player in players)
                {
                    PlayerControl playerControl = new PlayerControl
                    {
                        PlayerName = player.Name,
                        PlayerShirtNumber = (int)player.ShirtNumber,
                        PlayerPostion = player.Position,
                        IsCaptain = (bool)player.Captain,
                        IsFavorite = false
                    };

                    if (playerPictures.ContainsKey(player.Name))
                    {
                        playerControl.PlayerImage.ImageLocation = playerPictures[player.Name];
                    }

                    playerControl.MouseDown += PlayerControl_MouseDown;
                    if (favoritePlayers.Count > 0)
                    {
                        foreach (var favoritePlayer in favoritePlayers)
                        {
                            if (favoritePlayer == playerControl.PlayerName)
                            {
                                playerControl.IsFavorite = true;
                                flpFavPlayers.Controls.Add(playerControl);
                                break;
                            }
                            else
                            {
                                flpAllPlayers.Controls.Add(playerControl);
                            }
                        }
                    }
                    else
                    {
                        flpAllPlayers.Controls.Add(playerControl);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
                throw;
            }
        }

        private void PlayerControl_MouseDown(object sender, MouseEventArgs e)
        => (sender as PlayerControl).DoDragDrop(sender as PlayerControl, DragDropEffects.Move);

        private void cbTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserFavorites.SaveTeam((cbTeams.SelectedItem as dynamic).Text);
            selectedTeam = (cbTeams.SelectedItem as dynamic).Value;
            flpAllPlayers.Controls.Clear();
            flpFavPlayers.Controls.Clear();
            InitPlayers();
        }

        private void flpPlayers_DragDrop(object sender, DragEventArgs e)
        {
            PlayerControl pc = e.Data.GetData(typeof(PlayerControl)) as PlayerControl;
            FlowLayoutPanel dest = sender as FlowLayoutPanel;

            dest.Controls.Add(pc);
            if (dest.Name == "flpFavPlayers")
            {
                ChangeFavoritePlayer(pc, true);
            }
            else
            {
                ChangeFavoritePlayer(pc, false);
            }
        }

        private void flpPlayers_DragEnter(object sender, DragEventArgs e)
        {
            if (flpFavPlayers.Controls.Count > 2 && (sender as FlowLayoutPanel).Name == "flpFavPlayers")
            {
                return;
            }
            e.Effect = DragDropEffects.Move;
        }
        public static void ChangeFavoritePlayer(PlayerControl pc, bool isFavorite)
        {
            pc.IsFavorite = isFavorite;
            if (isFavorite)
            {
                favoritePlayers.Add(pc.PlayerName);
            }
            else
            {
                favoritePlayers.Remove(pc.PlayerName);
            }
            UserFavorites.SavePlayers(favoritePlayers);
        }

        public static void SavePicture(string player, string picturePath)
        {
            // Remove old player picture if exists
            if (playerPictures.ContainsKey(player))
            {
                playerPictures.Remove(player);

            }
            playerPictures.Add(player, picturePath);

            Repo.SavePlayerPicture(playerPictures);
        }

        private void btnRankingList_Click(object sender, EventArgs e)
        {
            RankingListForm form = new RankingListForm();
            form.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ChangeSettings changeSettings = new ChangeSettings();
            if (changeSettings.ShowDialog() == DialogResult.OK)
            {
                InitSettings();
                InitTeams();
            }
        }

        private void FavoritesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Really close?", "Exit", MessageBoxButtons.YesNo) == DialogResult.No)
            //    e.Cancel = true;
        }
    }
}

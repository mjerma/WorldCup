using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPF.UserControls;

namespace WPF
{
    /// <summary>
    /// Interaction logic for Teams.xaml
    /// </summary>
    public partial class Teams : Window
    {
        private static string[] settings;
        private static int[] resolution;
        private static string favTeamFifaCode;
        private static List<TeamDetails> favTeamDetails;
        private static string opponentTeamFifaCode;
        private static Dictionary<string, string> playerPictures;
        public Teams()
        {
            InitializeComponent();
            InitSettings();
            InitTeams();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void InitSettings()
        {
            try
            {
                settings = UserSettings.Load();
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(settings[1]);
                if (settings[2] == "Fullscreen")
                {
                    WindowState = WindowState.Maximized;
                    WindowStyle = WindowStyle.None;
                }
                else
                {
                    resolution = SplitResolutionInfo(settings);
                    Width = resolution[0];
                    Height = resolution[1];
                    WindowState = WindowState.Normal;
                    WindowStyle = WindowStyle.SingleBorderWindow;
                }
                InitializeComponent();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
                MessageBox.Show(ex.Message);
            }
        }

        private int[] SplitResolutionInfo(string[] settings)
        {
            int[] resolution = settings[2].Split('x').Select(int.Parse).ToArray();
            return resolution;
        }

        private void InitTeams()
        {
            try
            {
                foreach (var team in Repo.GetTeams(settings[0]))
                {
                    cbFavorite.Items.Add(team.Country + " (" + team.FifaCode + ")");
                }
                UserFavorites.CreateTeamFile();
                string favTeam = UserFavorites.ReadTeam();
                if (favTeam != "")
                {
                    cbFavorite.SelectedItem = favTeam;
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
            List<TeamDetails> matchDetails = favTeamDetails.Where(x => x.HomeTeam.Code == favTeamFifaCode && x.AwayTeam.Code == opponentTeamFifaCode
                                                                  || x.HomeTeam.Code == opponentTeamFifaCode && x.AwayTeam.Code == favTeamFifaCode)
                                                           .ToList();

            playerPictures = Repo.LoadPlayerPictures();
            CleanSoccerField();

            if (matchDetails[0].HomeTeam.Code == favTeamFifaCode)
            {
                LoadPlayerPositions(matchDetails[0].HomeTeamStatistics.StartingEleven,
                                    matchDetails[0].HomeTeamEvents, true);
                LoadPlayerPositions(matchDetails[0].AwayTeamStatistics.StartingEleven,
                                    matchDetails[0].AwayTeamEvents, false);
            }
            else
            {
                LoadPlayerPositions(matchDetails[0].AwayTeamStatistics.StartingEleven,
                                    matchDetails[0].AwayTeamEvents, true);
                LoadPlayerPositions(matchDetails[0].HomeTeamStatistics.StartingEleven,
                                    matchDetails[0].HomeTeamEvents, false);
            }
        }

        private void CleanSoccerField()
        {
            spGoalieFav.Children.Clear();
            spGoalieOpposing.Children.Clear();
            spDefenderFav.Children.Clear();
            spDefenderOpposing.Children.Clear();
            spMidfieldFav.Children.Clear();
            spMidfieldOpposing.Children.Clear();
            spForwardFav.Children.Clear();
            spForwardOpposing.Children.Clear();
        }

        private void LoadPlayerPositions(List<Player> startingEleven, List<TeamEvents> teamEvents, bool isFavorite)
        {
            List<PlayerStats> playerStats = LoadPlayerStats(startingEleven, teamEvents, isFavorite);

            foreach (var player in startingEleven)
            {
                PlayerStats ps = GetPlayerStats(player, playerStats);
                string playerText = player.Name.Substring(player.Name.IndexOf(' ') + 1);
                string playerShirtNumber = player.ShirtNumber.ToString();
                string playerFullName = player.Name;
                string position = player.Position;
                string captain = player.Captain.ToString();
                string goals = ps.Goals.ToString();
                string yellowCards = ps.YellowCard.ToString();

                switch (player.Position)
                {
                    case "Goalie":
                        PlayerControl goalie = 
                            CreatePlayer(playerText, playerShirtNumber, playerFullName, position, captain, goals, yellowCards);

                        if (playerPictures.ContainsKey(player.Name))
                        {
                            goalie.PlayerImage = new BitmapImage(new Uri(playerPictures[player.Name]));
                        }
                        if (isFavorite)
                            spGoalieFav.Children.Add(goalie);
                        else spGoalieOpposing.Children.Add(goalie);
                        break;
                    case "Defender":
                        PlayerControl defender = 
                            CreatePlayer(playerText, playerShirtNumber, playerFullName, position, captain, goals, yellowCards);

                        if (playerPictures.ContainsKey(player.Name))
                        {
                            defender.PlayerImage = new BitmapImage(new Uri(playerPictures[player.Name]));
                        }
                        if (isFavorite)
                            spDefenderFav.Children.Add(defender);
                        else spDefenderOpposing.Children.Add(defender);
                        break;
                    case "Midfield":
                        PlayerControl midfield = 
                            CreatePlayer(playerText, playerShirtNumber, playerFullName, position, captain, goals, yellowCards);

                        if (playerPictures.ContainsKey(player.Name))
                        {
                            midfield.PlayerImage = new BitmapImage(new Uri(playerPictures[player.Name]));
                        }
                        if (isFavorite)
                            spMidfieldFav.Children.Add(midfield);
                        else spMidfieldOpposing.Children.Add(midfield);
                        break;
                    case "Forward":
                        PlayerControl forward =
                            CreatePlayer(playerText, playerShirtNumber, playerFullName, position, captain, goals, yellowCards);

                        if (playerPictures.ContainsKey(player.Name))
                        {
                            forward.PlayerImage = new BitmapImage(new Uri(playerPictures[player.Name]));
                        }
                        if (isFavorite)
                            spForwardFav.Children.Add(forward);
                        else spForwardOpposing.Children.Add(forward);
                        break;
                }
            }
        }

        private PlayerControl CreatePlayer(string playerText, string playerShirtNumber, string playerFullName, string position, string captain, string goals, string yellowCards)
        {
            PlayerControl pc = new PlayerControl
            {
                PlayerText = playerText,
                PlayerShirtNumber = playerShirtNumber,
                PlayerFullName = playerFullName,
                Position = position,
                Captain = captain,
                Goals = goals,
                YellowCards = yellowCards
            };

            return pc;
        }

        private PlayerStats GetPlayerStats(Player player, List<PlayerStats> playerStats)
        {
            PlayerStats ps = new PlayerStats(player.Name, 0, 0);
            foreach (var stat in playerStats)
            {
                if (player.Name == stat.PlayerName)
                {
                    ps.Goals = stat.Goals;
                    ps.YellowCard = stat.YellowCard;
                }
            }
            return ps;
        }

        private List<PlayerStats> LoadPlayerStats(List<Player> startingEleven, List<TeamEvents> teamEvents, bool isFavorite)
        {
            List<PlayerStats> playerStats = new List<PlayerStats>();
            int index = 0;
            foreach (var teamEvent in teamEvents)
            {
                if (startingEleven.FindIndex(p => p.Name == teamEvent.Player) != -1)
                {
                    if (teamEvent.TypeOfEvent == "yellow-card" || teamEvent.TypeOfEvent == "yellow-card-second")
                    {
                        index = playerStats.FindIndex(p => p.PlayerName == teamEvent.Player);
                        if (index != -1)
                            playerStats[index].YellowCard++;
                        else
                            playerStats.Add(new PlayerStats(teamEvent.Player, 1, 0));
                    }
                    if (teamEvent.TypeOfEvent == "goal")
                    {
                        index = playerStats.FindIndex(p => p.PlayerName == teamEvent.Player);
                        if (index != -1)
                        {
                            playerStats[index].Goals++;
                        }
                        else playerStats.Add(new PlayerStats(teamEvent.Player, 0, 1));
                    }
                }
            }
            return playerStats;
        }

        private void cbFavorite_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                cbOpponent.Items.Clear();
                CleanSoccerField();
                string selectedCbItem = (sender as ComboBox).SelectedItem.ToString();
                string[] team = SplitTeamInfo(selectedCbItem);
                favTeamFifaCode = team[1];
                UserFavorites.SaveTeam(selectedCbItem);
                LoadOpponentTeams(favTeamFifaCode);
                btnFavoriteStats.IsEnabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void cbOpponent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                string[] team = SplitTeamInfo((sender as ComboBox).SelectedItem.ToString());
                opponentTeamFifaCode = team[1];
                btnOpponentStats.IsEnabled = true;
                InitPlayers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private string[] SplitTeamInfo(string teamInfo)
        {
            string[] team = teamInfo.Split('(', ')');
            return team;
        }

        private void LoadOpponentTeams(string favTeamFifaCode)
        {
            try
            {
                favTeamDetails = Repo.GetTeamDetails(settings[0], favTeamFifaCode);
                List<TeamInfo> opponentList = favTeamDetails.Where(x => x.HomeTeam.Code != favTeamFifaCode)
                                                            .Select(y => y.HomeTeam)
                                                            .ToList();

                opponentList.AddRange(favTeamDetails.Where(x => x.AwayTeam.Code != favTeamFifaCode)
                                                    .Select(y => y.AwayTeam)
                                                    .ToList());

                foreach (var team in opponentList)
                {
                    cbOpponent.Items.Add(team.Country + " (" + team.Code + ")");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            ChangeSettings settings = new ChangeSettings();

            if (settings.ShowDialog() == true)
            {
                try
                {
                    CleanSoccerField();
                    cbOpponent.Items.Clear();
                    cbFavorite.Items.Clear();
                    InitSettings();
                    InitTeams();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnFavoriteStats_Click(object sender, RoutedEventArgs e)
        {
            LoadTeamStats(favTeamFifaCode);
        }

        private void btnOpponentStats_Click(object sender, RoutedEventArgs e)
        {
            LoadTeamStats(opponentTeamFifaCode);
        }

        private void LoadTeamStats(string teamFifaCode)
        {
            try
            {
                List<TeamDetails> teamDetails = Repo.GetTeamDetails(settings[0], teamFifaCode);

                List<TeamInfo> teamInfo = teamDetails.Select(y => y.HomeTeam)
                                                        .ToList();
                teamInfo.AddRange(teamDetails.Select(y => y.AwayTeam)
                                                .ToList());

                TeamStats stats = new TeamStats();
                stats.Team = teamInfo.Where(x => x.Code == teamFifaCode).Select(x => x.Country).First().ToString();
                stats.FifaCode = teamFifaCode;
                stats.GamesPlayed = teamDetails.Count().ToString();
                stats.Wins = teamDetails.Where(x => x.WinnerCode == teamFifaCode).Select(x => x.Winner).ToList().Count.ToString();
                stats.Losses = teamDetails.Where(x => x.WinnerCode != teamFifaCode).Select(x => x.Winner).ToList().Count.ToString();
                stats.Scored = teamInfo.Where(d => d.Code == teamFifaCode).Select(x => x.Goals).Sum(x => x).ToString();
                stats.Recieved = teamInfo.Where(d => d.Code != teamFifaCode).Select(x => x.Goals).Sum(x => x).ToString();
                stats.Difference = (int.Parse(stats.tbScored.Text) - int.Parse(stats.tbReceived.Text)).ToString();
                stats.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}

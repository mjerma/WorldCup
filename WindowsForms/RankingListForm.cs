using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Properties;

namespace WindowsForms
{
    public partial class RankingListForm : Form
    {
        private static string[] settings;
        private static List<TeamDetails> teamDetails;
        private static List<Player> allPlayers;
        private static Dictionary<string, string> playerPictures;
        private static string FifaCode;
        private static Bitmap bmp;

        public RankingListForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            LoadDetails();
            InitPlayersTable();
            InitVisitorsTable();
        }

        private void LoadDetails()
        {
            settings = UserSettings.Load(); 
            string team = UserFavorites.ReadTeam();
            FifaCode = team.Split('(', ')')[1];
            teamDetails = Repo.GetTeamDetails(settings[0], FifaCode);
            allPlayers = Repo.GetPlayers(settings[0], FifaCode);
            playerPictures = Repo.LoadPlayerPictures();
        }

        private void InitPlayersTable()
        {
            List<PlayerStats> allplayerStats = new List<PlayerStats>();
            foreach (var matchDetails in teamDetails)
            {
                List<TeamEvents> allMatchEvents = matchDetails.HomeTeamEvents;
                allMatchEvents.AddRange(matchDetails.AwayTeamEvents);
                foreach (var matchEvent in allMatchEvents)
                {
                    if (allPlayers.Exists(x => x.Name == matchEvent.Player))
                    {
                        int index;
                        if (matchEvent.TypeOfEvent == "yellow-card" || matchEvent.TypeOfEvent == "yellow-card-second")
                        {
                            index = allplayerStats.FindIndex(p => p.PlayerName == matchEvent.Player);
                            if (index != -1)
                                allplayerStats[index].YellowCard++;
                            else
                                allplayerStats.Add(new PlayerStats(matchEvent.Player, 1, 0));
                        }
                        if (matchEvent.TypeOfEvent == "goal")
                        {
                            index = allplayerStats.FindIndex(p => p.PlayerName == matchEvent.Player);
                            if (index != -1)
                                allplayerStats[index].Goals++;
                            else
                                allplayerStats.Add(new PlayerStats(matchEvent.Player, 0, 1));
                        }
                    }
                }
            }

            dgvPlayerRanking.RowTemplate.Height = 60;

            foreach (var playerStats in allplayerStats)
            {
                Image img = Resources.playerDefault;
                foreach (var playerPicture in playerPictures)
                {
                    if (playerPicture.Key == playerStats.PlayerName)
                    {
                        img = Image.FromFile(playerPicture.Value);
                    }
                }
                dgvPlayerRanking.Rows.Add(img, playerStats.PlayerName, playerStats.YellowCard, playerStats.Goals);
            }
        }

        private void InitVisitorsTable()
        {
            foreach (var item in teamDetails)
            {
                dgvAttendanceRanking.Rows.Add(item.Location, item.Attendance, item.HomeTeamCountry, item.AwayTeamCountry);
            }
        }

        private void btnPrintPlayerTable_Click(object sender, EventArgs e)
        {
            int height = dgvPlayerRanking.Height;
            dgvPlayerRanking.Height = dgvPlayerRanking.RowCount * dgvPlayerRanking.RowTemplate.Height * 2;
            bmp = new Bitmap(dgvPlayerRanking.Width, dgvPlayerRanking.Height);
            dgvPlayerRanking.DrawToBitmap(bmp, new Rectangle(0, 0, dgvPlayerRanking.Width, dgvPlayerRanking.Height));
            dgvPlayerRanking.Height = height;
            printPreviewDialog.ShowDialog();
        }
        private void btnPrintAttendanceTable_Click(object sender, EventArgs e)
        {
            int height = dgvAttendanceRanking.Height;
            dgvAttendanceRanking.Height = dgvAttendanceRanking.RowCount * dgvAttendanceRanking.RowTemplate.Height * 2;
            bmp = new Bitmap(dgvAttendanceRanking.Width, dgvAttendanceRanking.Height);
            dgvAttendanceRanking.DrawToBitmap(bmp, new Rectangle(0, 0, dgvAttendanceRanking.Width, dgvAttendanceRanking.Height));
            dgvAttendanceRanking.Height = height;
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //e.Graphics.DrawImage(bmp, (e.PageBounds.Width - bmp.Width) / 2,
            //         (e.PageBounds.Height - bmp.Height) / 2, bmp.Width, bmp.Height);
            e.Graphics.DrawImage(bmp, (e.PageBounds.Width - bmp.Width) / 2, 0);
        }

        
    }
}

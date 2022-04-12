using DAL.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace DAL
{
    public class Repo
    {
        private const string MEN_TEAMS = "http://world-cup-json-2018.herokuapp.com/teams/results";
        private const string WOMEN_TEAMS = "http://worldcup.sfg.io/teams/results";
        private const string MEN_COUNTRY_MATCHES = "http://world-cup-json-2018.herokuapp.com/matches/country?fifa_code=";
        private const string WOMEN_COUNTRY_MATCHES = "http://worldcup.sfg.io/matches/country?fifa_code=";

        private const char DLM = '|';
        private const string PICTURES_FILENAME = @"playerPictures.txt";
        private static readonly string DIR
            = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()))) + @"\";
        private static readonly string PICTURES_FILE_PATH = DIR + PICTURES_FILENAME;
        

        public static List<Team> GetTeams(string gender)
        {
            string json = string.Empty;
            switch (gender)
            {
                case "Male":
                    json = GetJsonString(MEN_TEAMS);
                    break;
                case "Female":
                    json = GetJsonString(WOMEN_TEAMS);
                    break;
            }
            List<Team> teams = JsonConvert.DeserializeObject<List<Team>>(json);
            return teams;
        }

        public static List<TeamDetails> GetTeamDetails(string gender, string FifaCode)
        {
            string json = string.Empty;
            switch (gender)
            {
                case "Male":
                    json = GetJsonString(MEN_COUNTRY_MATCHES + FifaCode);
                    break;
                case "Female":
                    json = GetJsonString(WOMEN_COUNTRY_MATCHES + FifaCode);
                    break;
            }
            List<TeamDetails> teamDetails = JsonConvert.DeserializeObject<List<TeamDetails>>(json);
            
            return teamDetails;
        }

        public static List<Player> GetPlayers(string gender, string FifaCode)
        {
            string json = string.Empty;
            switch (gender)
            {
                case "Male":
                    json = GetJsonString(MEN_COUNTRY_MATCHES + FifaCode);
                    break;
                case "Female":
                    json = GetJsonString(WOMEN_COUNTRY_MATCHES + FifaCode);
                    break;
            }
            List<TeamDetails> allTeamDetails = JsonConvert.DeserializeObject<List<TeamDetails>>(json);
            List<Player> players = allTeamDetails
                                           .Where(x => x.HomeTeam.Code == FifaCode)
                                           .Select(y => y.HomeTeamStatistics.StartingEleven)
                                           .FirstOrDefault();
            List<Player> substitutes = allTeamDetails
                                           .Where(x => x.HomeTeam.Code == FifaCode)
                                           .Select(y => y.HomeTeamStatistics.Substitutes)
                                           .FirstOrDefault();

            players.AddRange(substitutes);

            return players;
        }

        private static string GetJsonString(string url)
        {
            string json = string.Empty;
            using (WebClient client = new WebClient())
            {
                json = client.DownloadString(url);
            }
            return json;
        }

        public static void CreatePicturesFile()
        {
            if (!File.Exists(PICTURES_FILE_PATH))
            {
                File.Create(PICTURES_FILE_PATH).Close();
            }
        }

        public static void SavePlayerPicture(Dictionary<string,string> playerPictures)
        {
            using (StreamWriter file = new StreamWriter(PICTURES_FILE_PATH))
            {
                foreach (var picture in playerPictures)
                {
                    file.WriteLine(picture.Key + DLM + picture.Value);
                }
            }
        }
        public static Dictionary<string, string> LoadPlayerPictures()
        {
            Dictionary<string, string> playerPictures = new Dictionary<string, string>();

            var lines = File.ReadLines(PICTURES_FILE_PATH);
            foreach (var line in lines)
            {
                string[] data = line.Split(DLM);
                playerPictures.Add(data[0], data[1]);
            }

            return playerPictures;
        }

    }
}

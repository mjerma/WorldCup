using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace DAL
{
    public class UserFavorites
    {
        private const char DLM = '|';
        private const string FAV_TEAM_FILENAME = @"favoriteTeam.txt";
        private const string FAV_PLAYERS_FILENAME = @"favoritePlayers.txt";
        private static readonly string DIR
            = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()))) + @"\";
        private static readonly string FAV_TEAM_PATH = DIR + FAV_TEAM_FILENAME;
        private static readonly string FAV_PLAYERS_PATH = DIR + FAV_PLAYERS_FILENAME;
        public static void CreateTeamFile()
        {
            if (!File.Exists(FAV_TEAM_PATH))
            {
                File.Create(FAV_TEAM_PATH).Close();
            }
        }

        public static void CreatePlayersFile()
        {
            if (!File.Exists(FAV_PLAYERS_PATH))
            {
                File.Create(FAV_PLAYERS_PATH).Close();
            }
        }

        public static void SaveTeam(string team)
        {
            File.WriteAllText(FAV_TEAM_PATH, $"{team}");
        }

        public static string ReadTeam()
        {
            string team = string.Empty;
            try
            {
                team = File.ReadAllText(FAV_TEAM_PATH);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }
            return team;
        }

        public static void SavePlayers(List<string> players)
        {
            using (StreamWriter file = new StreamWriter(FAV_PLAYERS_PATH))
            {
                foreach (var player in players)
                {
                    file.WriteLine(player);
                }
            }
        }

        public static List<string> ReadPlayers()
        {
            List<string> players = new List<string>();
            var lines = File.ReadLines(FAV_PLAYERS_PATH);
            foreach (var line in lines)
            {
                players.Add(line);
            }
            return players;
        }
    }
}

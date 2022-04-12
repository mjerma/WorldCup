using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserSettings
    {
        private const char DLM = '|';
        private const string FILENAME = @"settings.txt";
        private static readonly string DIR
            = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())));
        private static readonly string PATH = DIR + @"\" + FILENAME;

        public static void Create()
        {
            File.Create(PATH).Close();
        }
        public static void Save(string gender, string language)
        {
            File.WriteAllText(PATH, $"{gender}{DLM}{language}");
        }

        public static void Save(string gender, string language, string resolution)
        {
            File.WriteAllText(PATH, $"{gender}{DLM}{language}{DLM}{resolution}");
        }

        public static string[] Load()
        {
            return File.ReadAllText(PATH).Split(DLM);
        }

        public static bool Exists()
        {
            if (File.Exists(PATH))
            {
                return true;
            }
            else return false;
        }
    }
}

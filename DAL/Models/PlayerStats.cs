using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class PlayerStats
    {
        public string ImagePath { get; set; }
        public string PlayerName { get; set; }
        public int YellowCard { get; set; }
        public int Goals { get; set; }

        public PlayerStats(string playerName, int yellowCard, int goals)
        {
            PlayerName = playerName;
            YellowCard = yellowCard;
            Goals = goals;
        }
    }
}

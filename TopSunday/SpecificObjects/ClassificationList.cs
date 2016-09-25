using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TopSunday.SpecificObjects
{
    public class ClassificationList
    {
        public int PlayerID { get; set; }
        public PlayerResume Player { get; set; }
        public int NumGames { get; set; }
        public int Wins { get; set; }
        public int Loses { get; set; }
        public int Draws { get; set; }
        public int TotalPoints { get; set; }
        public int Goals { get; set; }
        public string PlayerName { get; internal set; }
    }
}
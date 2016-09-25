using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TopSunday.SpecificObjects
{
    public class PlayerResume
    {
        public int PlayerID { get; set; }
        public string PlayerName { get; set; }
        public int Games { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Loses { get; set; }
        public int Goals { get; set; }
    }
}
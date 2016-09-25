using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TopSunday.Models;

namespace TopSunday.SpecificObjects
{
    public class PlayerConfirmation
    {
        public int PlayerID { get; set; }
        public string PlayerName { get; set; }
        public bool GoToGame { get; set; }
        public bool IsSubstitute { get; set; }
        public Classification Classification { get; set; }
    }
}
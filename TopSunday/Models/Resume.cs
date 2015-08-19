using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TopSunday.Models
{
    public class Resume
    {
        public int ID { get; set; }
        public int GameID { get; set; }
        public virtual Game Game { get; set; }
    }
}
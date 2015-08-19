using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TopSunday.Models
{
    public class Player
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Stars { get; set; }
        public int GamesCounter { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TopSunday.Models
{
    public class Game
    {
        [Key]
        public int ID { get; set; }
        public DateTime Data { get; set; }
    }
}
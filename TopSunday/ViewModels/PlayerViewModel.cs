using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TopSunday.Models;

namespace TopSunday.ViewModels
{
    public class PlayerViewModel
    {
        public int ID { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Contacto")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Valor em divida")]
        public decimal Debit { get; set; }

        [Display(Name = "Domingo")]
        public bool Sunday { get; set; }
        [Display(Name = "Quarta")]
        public bool Wednesday { get; set; }

    }
}
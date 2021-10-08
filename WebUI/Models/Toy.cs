using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
    {
    public class Toy
        {
        [Required]
        public string exclamation { get; set; }
        [Required]
        public string sound { get; set; }
        [Required]
        public string adjective { get; set; }
        [Required]
        public string noun { get; set; }
        [Required]
        public string month { get; set; }
        [Required]
        public string sound2 { get; set; }
        [Required]
        public string adjective2 { get; set; }
        [Required]
        public string noun2 { get; set; }
        [Required]
        public string verb { get; set; }
        [Required]
        public string verb2 { get; set; }
        [Required]
        public string beverage { get; set; }
        [Required]
        public string number { get; set; }
        [Required]
        public string color { get; set; }
        [Required]
        public string number2 { get; set; }
        [Required]
        public string nounPl { get; set; }
        [Required]
        public string nounPl2 { get; set; }
        }
    }

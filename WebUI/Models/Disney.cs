using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
    {
    public class Disney
        {
        [Required]
        public string name { get; set; }
        [Required]
        public string number { get; set; }
        [Required]
        public string vehicle { get; set; }
        [Required]
        public string adjective { get; set; }
        [Required]
        public string adjective2 { get; set; }
        [Required]
        public string verb { get; set; }
        [Required]
        public string animal { get; set; }
        [Required]
        public string adjective3 { get; set; }
        [Required]
        public string verbPt { get; set; }
        [Required]
        public string adjective4 { get; set; }
        [Required]
        public string name2 { get; set; }
        [Required]
        public string verbPt2 { get; set; }
        [Required]
        public string verbPt3 { get; set; }
        [Required]
        public string place { get; set; }
        [Required]
        public string verb2 { get; set; }

        }
    }

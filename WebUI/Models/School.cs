using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
    {
    public class School
        {
        [Required]
        public string noun { get; set; }
        [Required]
        public string adjective { get; set; }
        [Required]
        public string number { get; set; }
        [Required]
        public string adjective2 { get; set; }
        [Required]
        public string noun2 { get; set; }
        [Required]
        public string nounPr { get; set; }
        [Required]
        public string nounPr2 { get; set; }
        [Required]
        public string nounPl { get; set; }
        [Required]
        public string verb { get; set; }
        [Required]
        public string nounPl2 { get; set; }
        [Required]
        public string adjective3 { get; set; }
        [Required]
        public string adverb { get; set; }
        }
    }

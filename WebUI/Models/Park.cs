using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
    {
    public class Park
        {
        [Required]
        public string adjective { get; set; }
        [Required]
        public string nounPl { get; set; }
        [Required]
        public string noun { get; set; }
        [Required]
        public string adverb { get; set; }
        [Required]
        public string number { get; set; }
        [Required]
        public string verbPt { get; set; }
        [Required]
        public string adjective2 { get; set; }
        [Required]
        public string verbPt2 { get; set; }
        [Required]
        public string adverb2 { get; set; }
        [Required]
        public string adjective4 { get; set; }
        }
    }

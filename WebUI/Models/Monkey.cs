using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
    {
    public class Monkey
        {
        [Required]
        public string verb { get; set; }
        [Required]
        public string noun { get; set; }
        [Required]
        public string adjective { get; set; }
        [Required]
        public string adverb { get; set; }
       
        }
    }

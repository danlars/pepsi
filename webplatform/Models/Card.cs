using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webplatform.Models
{
    public class Card
    {
        public int id { get; set; } 

        [Required]
        public string title { get; set; }

        [Required]
        public string description { get; set; }

        [Required]
        public DateTime date { get; set; }

        [Required]
        //[RegularExpression()]
        public string color { get; set; }

        public int job_id { get; set; }

        public int weight_id { get; set; }
    }
}
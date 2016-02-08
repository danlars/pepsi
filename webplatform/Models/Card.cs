using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Microsoft.SqlServer.Server;

namespace webplatform.Models
{
    public class Card
    {
        public int id { get; set; } 

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Titel")]
        public string title { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Beskrivelse")]
        public string description { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Hvornår skal den være færdig")]
        public DateTime date { get; set; }

        [Required]
        [Display(Name = "Farve")]
        public string color { get; set; }

        [ForeignKey("Job")]
        public int job_id { get; set; }

        public int weight_id { get; set; }

        public virtual Job Job { get; set; }
    }
}
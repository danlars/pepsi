using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webplatform.Models
{
    public class Board
    {
        public int id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Projektnavn")]
        public string title { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Beskrivelse")]
        public string description { get; set; }

        //Relations
        public virtual Team team { get; set; }
        public virtual ICollection<Job> jobs { get; set; }
    }
}
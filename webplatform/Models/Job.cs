using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace webplatform.Models
{
    public class Job
    {
        public int id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Process")]
        public string title { get; set; }

        [ForeignKey("Board")]
        public int BoardId { get; set; }

        public int weight_id { get; set; }

        //Relations
        public virtual Board Board { get; set; }
        public virtual ICollection<Card> Cards { get; set; }
    }
}
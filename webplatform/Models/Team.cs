using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webplatform.Models
{
    public class Team
    {
        public Guid id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Holdnavn")]
        public string Title { get; set; }

        //Relations
        public virtual ICollection<Board> Boards { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webplatform.Models
{
    public class Card
    {
        public int id { get; set; } 

        public string title { get; set; }

        public string description { get; set; }

        public int job_id { get; set; }

        public int weight_id { get; set; }
    }
}
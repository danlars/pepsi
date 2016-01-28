using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webplatform.Models
{
    public class Job
    {
        public int id { get; set; } 

        public string title { get; set; }

        public int board_id { get; set; }

        public int weight_id { get; set; }

    }
}
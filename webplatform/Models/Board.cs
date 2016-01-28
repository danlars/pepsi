using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webplatform.Models
{
    public class Board
    {
        public int id { get; set; }

        public string name { get; set; }

        public DateTime updated_at { get; set; }

        public DateTime created_at { get; set; }
    }
}
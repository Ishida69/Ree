using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReeTail.Models
{
    public class ListeningItems
    {
        public string ItemImg { get; set; } 
        public string ItemTitle { get; set; }
        public string ItemDescription { get; set; }
        public double Price { get; set; }
        public string ItemCondition { get; set; }
        public string Category { get; set; }

    }
}
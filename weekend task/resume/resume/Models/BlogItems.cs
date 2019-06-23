using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace resume.Models
{
    public class BlogItems
    {
        public int Id { get; set; }
        public string PhotoPath { get; set; }
        public string UpperTitle { get; set; }
        public string Text { get; set; }
        public DateTime DateShared { get; set; }
    }
}
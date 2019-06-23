using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace resume.Models
{
    public class ExperienceTable
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public string FinishTime { get; set; }
        public string Place { get; set; }
        public string City { get; set; }
        public string Position { get; set; }
        public string About { get; set; }
    }
}
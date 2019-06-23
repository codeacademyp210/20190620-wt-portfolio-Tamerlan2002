using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace resume.Models
{
    public class EducationTables
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public string Univeristy { get; set; }
        public string Faculty { get; set; }
        public string StartingYear { get; set; }
        public string FinishingYear { get; set; }
    }
}
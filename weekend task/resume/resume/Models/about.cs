using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace resume.Models
{
    public class About
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string Profession { get; set; }
        public string Place { get; set; }
        public string Field { get; set; }
        public string Previous { get; set; }
        public string Education { get; set; }
    }
}
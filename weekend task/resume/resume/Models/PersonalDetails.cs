using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace resume.Models
{
    public class PersonalDetails
    {
        public int Id { get; set; }
        public DateTime Birthday{ get; set; }
        public string Martial { get; set; }
        public string Nationality { get; set; }
        public string Skype { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
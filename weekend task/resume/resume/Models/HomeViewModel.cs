using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace resume.Models
{
    public class HomeViewModel
    {
        public List<About> AboutList { get; set; }
        public List<BlogItems> BlogList { get; set; }
        public List<BriefAbout> BriefAboutList { get; set; }
        public List<Contact> ContactList { get; set; }
        public List<EducationTables> EducationTablesList { get; set; }
        public List<ExperienceTable> ExperienceTablesList { get; set; }
        public List<Languages> LanguagesList { get; set; }
        public List<PersonalDetails> PersonalDetailsList { get; set; }
        public List<Recommendations> RecommendationsList { get; set; }
        public List<SayHello> SayHelloList { get; set; }
        public List<Skills> SkillsList { get; set; }
        public List<Admin> Admin { get; set; }
    }
}
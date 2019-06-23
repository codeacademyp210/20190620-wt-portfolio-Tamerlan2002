using resume.DAL;
using resume.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace resume.Controllers
{
    public class HomeController : Controller
    {

        ResumeContext db = new ResumeContext();

        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();
            model.AboutList = db.AboutP.ToList();
            model.BlogList = db.BlogItems.ToList();
            model.BriefAboutList = db.BriefAbouts.ToList();
            model.ContactList = db.Contacts.ToList();
            model.EducationTablesList = db.EducationTables.ToList();
            model.ExperienceTablesList = db.ExperienceTables.ToList();
            model.LanguagesList = db.Languages.ToList();
            model.PersonalDetailsList = db.PersonalDetails.ToList();
            model.RecommendationsList = db.Recommendations.ToList();
            model.SayHelloList = db.SayHellos.ToList();
            model.SkillsList = db.Skills.ToList();
            model.Admin = db.Admin.ToList();
            return View(model);
        }
    }
}
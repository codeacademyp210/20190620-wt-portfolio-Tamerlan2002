namespace resume.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using resume.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<resume.DAL.ResumeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(resume.DAL.ResumeContext context)
        {
            context.AboutP.AddOrUpdate(x => x.Id,
                new About { Id = 1, NameSurname = "Adam Doe", Profession = "Chief Product Officer at Okler Themes", Place = "GREATER NEW YORK AREA", Field = "INFORMATION TECHNOLOGY & SERVICES", Previous = "FRONT-END DEVELOPER AT PORTO ", Education = "PORTO SCHOOL" }
        );
            context.BriefAbouts.AddOrUpdate(x => x.Id,
                new BriefAbout{ Id = 1, AboutText = "Donec id elit non mi porta gravida at eget metus. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus. Etiam porta sem malesuada magna mollis euismod. Donec sed odio dui." }
                );
            context.PersonalDetails.AddOrUpdate(x => x.Id,
                new PersonalDetails{Id = 1, Birthday = DateTime.Parse("1990-10-02"), Martial = "SINGLE", Nationality = "AMERICAN", Skype = "FILANKES", Phone = "055-555-55-55", Email = "ME@DOMAIN.COM"}
                );
            context.ExperienceTables.AddOrUpdate(x => x.Id,
                new ExperienceTable { Id = 1, StartTime = DateTime.Parse("2012-09-01"), FinishTime = "Present", Place = "Okler Themes", City = "GREATER NEW YORK", Position = "Chief Product Officer", About = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam tincidunt nulla tortor, a imperdiet enim tristique nec. Nulla lobortis leo eget metus dapibus sodales. Sed placerat vitae dui vitae vehicula. Quisque in tincidunt ligula, nec dignissim arcu." },
                new ExperienceTable { Id = 2, StartTime = DateTime.Parse("2012-09-01"), FinishTime = "Present", Place = "Okler Themes", City = "GREATER NEW YORK", Position = "Chief Product Officer", About = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam tincidunt nulla tortor, a imperdiet enim tristique nec. Nulla lobortis leo eget metus dapibus sodales. Sed placerat vitae dui vitae vehicula. Quisque in tincidunt ligula, nec dignissim arcu." },
                new ExperienceTable { Id = 3, StartTime = DateTime.Parse("2012-09-01"), FinishTime = "Present", Place = "Okler Themes", City = "GREATER NEW YORK", Position = "Chief Product Officer", About = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam tincidunt nulla tortor, a imperdiet enim tristique nec. Nulla lobortis leo eget metus dapibus sodales. Sed placerat vitae dui vitae vehicula. Quisque in tincidunt ligula, nec dignissim arcu." }
            );
            context.EducationTables.AddOrUpdate(x => x.Id,
                new EducationTables { Id = 1, Icon = "Icon-graduation", Univeristy = "Porto University", Faculty = "Master of Information Technology", StartingYear = "2001", FinishingYear = "2017" },
                new EducationTables { Id = 2, Icon = "Icon-graduation", Univeristy = "Porto University", Faculty = "Master of Information Technology", StartingYear = "2001", FinishingYear = "2017" },
                new EducationTables { Id = 3, Icon = "Icon-graduation", Univeristy = "Porto University", Faculty = "Master of Information Technology", StartingYear = "2001", FinishingYear = "2017" },
                new EducationTables { Id = 4, Icon = "Icon-graduation", Univeristy = "Porto University", Faculty = "Master of Information Technology", StartingYear = "2001", FinishingYear = "2017" },
                new EducationTables { Id = 5, Icon = "Icon-graduation", Univeristy = "Porto University", Faculty = "Master of Information Technology", StartingYear = "2001", FinishingYear = "2017" },
                new EducationTables { Id = 6, Icon = "Icon-graduation", Univeristy = "Porto University", Faculty = "Master of Information Technology", StartingYear = "2001", FinishingYear = "2017" }
            );
            context.Skills.AddOrUpdate(x => x.Id,
                new Skills { Id = 1, SkillName = "START UP", SkillPercent = "60" },
                new Skills { Id = 2, SkillName = "INNOVATION", SkillPercent = "80" },
                new Skills { Id = 3, SkillName = "PRODUCTS", SkillPercent = "70" },
                new Skills { Id = 4, SkillName = "CSS", SkillPercent = "90" },
                new Skills { Id = 5, SkillName = "JAVASCRIPT", SkillPercent = "60" },
                new Skills { Id = 6, SkillName = "BUSINESS", SkillPercent = "80" },
                new Skills { Id = 7, SkillName = "ECOMMERCE", SkillPercent = "70" },
                new Skills { Id = 8, SkillName = "CREATIVE", SkillPercent = "90" }
            );
            context.Recommendations.AddOrUpdate(x => x.Id,
                new Recommendations { Id = 1, Name = "BOB DOE", Work = "Director of Engineering", Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam tincidunt nulla tortor, a imperdiet enim tristique nec. Nulla lobortis leo eget metus dapibus sodales. Sed placerat vitae dui vitae vehicula. Quisque in tincidunt ligula, nec dignissim arcu. Praesent aliquam velit vel libero dictum, non sollicitudin lectus mollis. Morbi sollicitudin auctor gravida." },
                new Recommendations { Id = 2, Name = "BOB DOE", Work = "Director of Engineering", Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam tincidunt nulla tortor, a imperdiet enim tristique nec. Nulla lobortis leo eget metus dapibus sodales. Sed placerat vitae dui vitae vehicula. Quisque in tincidunt ligula, nec dignissim arcu. Praesent aliquam velit vel libero dictum, non sollicitudin lectus mollis. Morbi sollicitudin auctor gravida." }
            );
            context.BlogItems.AddOrUpdate(x => x.Id,
                new BlogItems { Id = 1, PhotoPath = null, DateShared = DateTime.Parse("2017-07-12"), UpperTitle = "Design Driven", Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam tincidunt nulla tortor, a imperdiet enim tristique nec. Nulla lobortis leo eget metus dapib..." },
                new BlogItems { Id = 2, PhotoPath = null, DateShared = DateTime.Parse("2017-07-12"), UpperTitle = "Design Driven", Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam tincidunt nulla tortor, a imperdiet enim tristique nec. Nulla lobortis leo eget metus dapib..." }
            );
            context.Contacts.AddOrUpdate(x => x.Id,
                new Contact { Id = 1, Email = "you@domain.com", Phone = "123-456-7890", Skype = "yourskype", Facebook = "Facebook", Twitter = "Twitter", Linkedin = "Linkedin" }
            );
        }
    }
}

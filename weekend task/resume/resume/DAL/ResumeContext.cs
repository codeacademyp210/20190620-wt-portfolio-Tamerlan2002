using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using resume.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace resume.DAL
{
    public class ResumeContext : DbContext
    {
        public ResumeContext() : base("ResumeContext")
        {
        }

        public DbSet<About> AboutP { get; set; }
        public DbSet<BlogItems> BlogItems { get; set; }
        public DbSet<BriefAbout> BriefAbouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<EducationTables> EducationTables { get; set; }
        public DbSet<ExperienceTable> ExperienceTables { get; set; }
        public DbSet<Languages> Languages { get; set; }
        public DbSet<PersonalDetails> PersonalDetails { get; set; }
        public DbSet<Recommendations> Recommendations { get; set; }
        public DbSet<SayHello> SayHellos { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Admin> Admin { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
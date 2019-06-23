namespace resume.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AD : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.About",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        Profession = c.String(),
                        Place = c.String(),
                        Field = c.String(),
                        Previous = c.String(),
                        Education = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Admin",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BlogItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PhotoPath = c.String(),
                        UpperTitle = c.String(),
                        Text = c.String(),
                        DateShared = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BriefAbout",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AboutText = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contact",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Phone = c.String(),
                        Skype = c.String(),
                        Facebook = c.String(),
                        Twitter = c.String(),
                        Linkedin = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EducationTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Icon = c.String(),
                        Univeristy = c.String(),
                        Faculty = c.String(),
                        StartingYear = c.String(),
                        FinishingYear = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ExperienceTable",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: false),
                        FinishTime = c.String(),
                        Place = c.String(),
                        City = c.String(),
                        Position = c.String(),
                        About = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        English = c.String(),
                        Spanish = c.String(),
                        French = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PersonalDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Birthday = c.DateTime(nullable: false),
                        Martial = c.String(),
                        Nationality = c.String(),
                        Skype = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Recommendations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        Name = c.String(),
                        Work = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SayHello",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Subject = c.String(),
                        Message = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SkillName = c.String(),
                        SkillPercent = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Skills");
            DropTable("dbo.SayHello");
            DropTable("dbo.Recommendations");
            DropTable("dbo.PersonalDetails");
            DropTable("dbo.Languages");
            DropTable("dbo.ExperienceTable");
            DropTable("dbo.EducationTables");
            DropTable("dbo.Contact");
            DropTable("dbo.BriefAbout");
            DropTable("dbo.BlogItems");
            DropTable("dbo.Admin");
            DropTable("dbo.About");
        }
    }
}

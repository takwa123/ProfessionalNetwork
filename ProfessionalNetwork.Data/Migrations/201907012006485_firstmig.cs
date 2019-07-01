namespace ProfessionalNetwork.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstmig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Application",
                c => new
                    {
                        Id_Application = c.Long(nullable: false, identity: true),
                        Date_Application = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        State = c.Int(nullable: false),
                        Job_OfferFK = c.Long(nullable: false),
                        Job_SeekerFK = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id_Application)
                .ForeignKey("dbo.Job_Offer", t => t.Job_OfferFK, cascadeDelete: true)
                .ForeignKey("dbo.Job_Seeker", t => t.Job_SeekerFK, cascadeDelete: true)
                .Index(t => t.Job_OfferFK)
                .Index(t => t.Job_SeekerFK);
            
            CreateTable(
                "dbo.Interview",
                c => new
                    {
                        Id_Interview = c.Long(nullable: false),
                        Date_Interview = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Type_Interview = c.Int(nullable: false),
                        State_interview = c.Int(nullable: false),
                        TestFK = c.Long(nullable: false),
                        Applciation_FK = c.Long(nullable: false),
                        Date_Created = c.DateTime(precision: 7, storeType: "datetime2"),
                        Date_Modified = c.DateTime(precision: 7, storeType: "datetime2"),
                        Date_Deleted = c.DateTime(precision: 7, storeType: "datetime2"),
                        IsDeleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id_Interview)
                .ForeignKey("dbo.Application", t => t.Applciation_FK, cascadeDelete: true)
                .ForeignKey("dbo.Test", t => t.TestFK)
                .Index(t => t.TestFK)
                .Index(t => t.Applciation_FK);
            
            CreateTable(
                "dbo.Test",
                c => new
                    {
                        Id_Test = c.Long(nullable: false, identity: true),
                        Nbr_Question = c.Int(nullable: false),
                        Nbr_Point_Tolal = c.Int(nullable: false),
                        Name_Test = c.String(),
                        Date_Created = c.DateTime(precision: 7, storeType: "datetime2"),
                        Date_Modified = c.DateTime(precision: 7, storeType: "datetime2"),
                        Date_Deleted = c.DateTime(precision: 7, storeType: "datetime2"),
                        IsDeleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id_Test);
            
            CreateTable(
                "dbo.Question",
                c => new
                    {
                        Id_Question = c.Long(nullable: false, identity: true),
                        Content_Question = c.String(),
                        Correct_AnswerID = c.Int(nullable: false),
                        Point_Question = c.Int(nullable: false),
                        Rank = c.Int(nullable: false),
                        choice1 = c.String(),
                        choice2 = c.String(),
                        choice3 = c.String(),
                        TestFK = c.Long(nullable: false),
                        Date_Created = c.DateTime(precision: 7, storeType: "datetime2"),
                        Date_Modified = c.DateTime(precision: 7, storeType: "datetime2"),
                        Date_Deleted = c.DateTime(precision: 7, storeType: "datetime2"),
                        IsDeleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id_Question)
                .ForeignKey("dbo.Test", t => t.TestFK, cascadeDelete: true)
                .Index(t => t.TestFK);
            
            CreateTable(
                "dbo.Job_Offer",
                c => new
                    {
                        Id_JobOffer = c.Long(nullable: false, identity: true),
                        job_title = c.String(),
                        Job_Description = c.String(),
                        Date_Offer = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Nbr_Candidat = c.Int(nullable: false),
                        Date_Expiration = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        visibility = c.Boolean(nullable: false),
                        EntrepirseFK = c.Long(nullable: false),
                        Date_Created = c.DateTime(precision: 7, storeType: "datetime2"),
                        Date_Modified = c.DateTime(precision: 7, storeType: "datetime2"),
                        Date_Deleted = c.DateTime(precision: 7, storeType: "datetime2"),
                        IsDeleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id_JobOffer)
                .ForeignKey("dbo.Entreprise_admin", t => t.EntrepirseFK, cascadeDelete: true)
                .Index(t => t.EntrepirseFK);
            
            CreateTable(
                "dbo.Entreprise_admin",
                c => new
                    {
                        Id_Entrepirse = c.Long(nullable: false, identity: true),
                        Name_Entrerise = c.String(),
                        Intro_Entreprise = c.String(),
                        NB_Employee = c.Int(nullable: false),
                        Role = c.String(),
                        Email = c.String(),
                        Username = c.String(),
                        Pwd = c.String(),
                        Enable = c.Boolean(nullable: false),
                        Photo = c.String(nullable: false),
                        Date_Created = c.DateTime(precision: 7, storeType: "datetime2"),
                        Date_Modified = c.DateTime(precision: 7, storeType: "datetime2"),
                        Date_Deleted = c.DateTime(precision: 7, storeType: "datetime2"),
                        IsDeleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id_Entrepirse);
            
            CreateTable(
                "dbo.Job_Seeker",
                c => new
                    {
                        id_jobseeker = c.Long(nullable: false, identity: true),
                        First_Name = c.String(),
                        Last_Name = c.String(),
                        Intro_jobseeker = c.String(),
                        Date_of_birth = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Certif = c.String(),
                        Skills = c.String(),
                        Email = c.String(),
                        Username = c.String(),
                        Pwd = c.String(),
                        Enable = c.Boolean(nullable: false),
                        Photo = c.String(nullable: false),
                        Date_Created = c.DateTime(precision: 7, storeType: "datetime2"),
                        Date_Modified = c.DateTime(precision: 7, storeType: "datetime2"),
                        Date_Deleted = c.DateTime(precision: 7, storeType: "datetime2"),
                        IsDeleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.id_jobseeker);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Application", "Job_SeekerFK", "dbo.Job_Seeker");
            DropForeignKey("dbo.Application", "Job_OfferFK", "dbo.Job_Offer");
            DropForeignKey("dbo.Job_Offer", "EntrepirseFK", "dbo.Entreprise_admin");
            DropForeignKey("dbo.Interview", "Id_Interview", "dbo.Test");
            DropForeignKey("dbo.Question", "TestFK", "dbo.Test");
            DropForeignKey("dbo.Interview", "Applciation_FK", "dbo.Application");
            DropIndex("dbo.Job_Offer", new[] { "EntrepirseFK" });
            DropIndex("dbo.Question", new[] { "TestFK" });
            DropIndex("dbo.Interview", new[] { "Applciation_FK" });
            DropIndex("dbo.Interview", new[] { "Id_Interview" });
            DropIndex("dbo.Application", new[] { "Job_SeekerFK" });
            DropIndex("dbo.Application", new[] { "Job_OfferFK" });
            DropTable("dbo.Job_Seeker");
            DropTable("dbo.Entreprise_admin");
            DropTable("dbo.Job_Offer");
            DropTable("dbo.Question");
            DropTable("dbo.Test");
            DropTable("dbo.Interview");
            DropTable("dbo.Application");
        }
    }
}

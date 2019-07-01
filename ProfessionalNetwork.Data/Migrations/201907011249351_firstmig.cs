namespace ProfessionalNetwork.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstmig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id_Account = c.Long(nullable: false, identity: true),
                        Email = c.String(),
                        Username = c.String(),
                        Pwd = c.String(),
                        Enable = c.Boolean(nullable: false),
                        Photo = c.String(nullable: false),
                        Date_Created = c.DateTime(precision: 7, storeType: "datetime2"),
                        Date_Modified = c.DateTime(precision: 7, storeType: "datetime2"),
                        Date_Deleted = c.DateTime(precision: 7, storeType: "datetime2"),
                        IsDeleted = c.Boolean(),
                        Id_Administrator = c.Long(),
                        Discriminator = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id_Account);
            
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
                        Id_Project_Manager = c.Int(nullable: false),
                        Date_Created = c.DateTime(precision: 7, storeType: "datetime2"),
                        Date_Modified = c.DateTime(precision: 7, storeType: "datetime2"),
                        Date_Deleted = c.DateTime(precision: 7, storeType: "datetime2"),
                        IsDeleted = c.Boolean(),
                        Project_Manager_Id_Account = c.Long(),
                    })
                .PrimaryKey(t => t.Id_JobOffer)
                .ForeignKey("dbo.Entreprise_admin", t => t.EntrepirseFK)
                .ForeignKey("dbo.Project_Manager", t => t.Project_Manager_Id_Account)
                .Index(t => t.EntrepirseFK)
                .Index(t => t.Project_Manager_Id_Account);
            
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
                .ForeignKey("dbo.Job_Offer", t => t.Job_SeekerFK, cascadeDelete: true)
                .ForeignKey("dbo.Job_Seeker", t => t.Job_SeekerFK)
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
                    })
                .PrimaryKey(t => t.Id_Interview)
                .ForeignKey("dbo.Application", t => t.Applciation_FK, cascadeDelete: true)
                .ForeignKey("dbo.Test", t => t.Id_Interview)
                .Index(t => t.Id_Interview)
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
                "dbo.Entreprise_admin",
                c => new
                    {
                        Id_Account = c.Long(nullable: false),
                        Id_Entrepirse = c.Long(nullable: false),
                        Name_Entrerise = c.String(),
                        Intro_Entreprise = c.String(),
                        NB_Employee = c.Int(nullable: false),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.Id_Account)
                .ForeignKey("dbo.Accounts", t => t.Id_Account)
                .Index(t => t.Id_Account);
            
            CreateTable(
                "dbo.Job_Seeker",
                c => new
                    {
                        Id_Account = c.Long(nullable: false),
                        Entreprise_admin_Id_Account = c.Long(),
                        id_jobseeker = c.Long(nullable: false),
                        First_Name = c.String(),
                        Last_Name = c.String(),
                        Intro_jobseeker = c.String(),
                        Date_of_birth = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Certif = c.String(),
                        Skills = c.String(),
                    })
                .PrimaryKey(t => t.Id_Account)
                .ForeignKey("dbo.Accounts", t => t.Id_Account)
                .ForeignKey("dbo.Entreprise_admin", t => t.Entreprise_admin_Id_Account)
                .Index(t => t.Id_Account)
                .Index(t => t.Entreprise_admin_Id_Account);
            
            CreateTable(
                "dbo.Project_Manager",
                c => new
                    {
                        Id_Account = c.Long(nullable: false),
                        Entreprise_admin_Id_Account = c.Long(),
                        Id_Project_Manager = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id_Account)
                .ForeignKey("dbo.Accounts", t => t.Id_Account)
                .ForeignKey("dbo.Entreprise_admin", t => t.Entreprise_admin_Id_Account)
                .Index(t => t.Id_Account)
                .Index(t => t.Entreprise_admin_Id_Account);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Project_Manager", "Entreprise_admin_Id_Account", "dbo.Entreprise_admin");
            DropForeignKey("dbo.Project_Manager", "Id_Account", "dbo.Accounts");
            DropForeignKey("dbo.Job_Seeker", "Entreprise_admin_Id_Account", "dbo.Entreprise_admin");
            DropForeignKey("dbo.Job_Seeker", "Id_Account", "dbo.Accounts");
            DropForeignKey("dbo.Entreprise_admin", "Id_Account", "dbo.Accounts");
            DropForeignKey("dbo.Job_Offer", "Project_Manager_Id_Account", "dbo.Project_Manager");
            DropForeignKey("dbo.Job_Offer", "EntrepirseFK", "dbo.Entreprise_admin");
            DropForeignKey("dbo.Application", "Job_SeekerFK", "dbo.Job_Seeker");
            DropForeignKey("dbo.Application", "Job_SeekerFK", "dbo.Job_Offer");
            DropForeignKey("dbo.Interview", "Id_Interview", "dbo.Test");
            DropForeignKey("dbo.Question", "TestFK", "dbo.Test");
            DropForeignKey("dbo.Interview", "Applciation_FK", "dbo.Application");
            DropIndex("dbo.Project_Manager", new[] { "Entreprise_admin_Id_Account" });
            DropIndex("dbo.Project_Manager", new[] { "Id_Account" });
            DropIndex("dbo.Job_Seeker", new[] { "Entreprise_admin_Id_Account" });
            DropIndex("dbo.Job_Seeker", new[] { "Id_Account" });
            DropIndex("dbo.Entreprise_admin", new[] { "Id_Account" });
            DropIndex("dbo.Question", new[] { "TestFK" });
            DropIndex("dbo.Interview", new[] { "Applciation_FK" });
            DropIndex("dbo.Interview", new[] { "Id_Interview" });
            DropIndex("dbo.Application", new[] { "Job_SeekerFK" });
            DropIndex("dbo.Job_Offer", new[] { "Project_Manager_Id_Account" });
            DropIndex("dbo.Job_Offer", new[] { "EntrepirseFK" });
            DropTable("dbo.Project_Manager");
            DropTable("dbo.Job_Seeker");
            DropTable("dbo.Entreprise_admin");
            DropTable("dbo.Question");
            DropTable("dbo.Test");
            DropTable("dbo.Interview");
            DropTable("dbo.Application");
            DropTable("dbo.Job_Offer");
            DropTable("dbo.Accounts");
        }
    }
}

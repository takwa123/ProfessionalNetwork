namespace ProfessionalNetwork.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id_Account = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Username = c.String(),
                        Pwd = c.String(),
                        Enable = c.Boolean(nullable: false),
                        Photo = c.String(nullable: false),
                        Id_Administrator = c.Int(),
                        Id_Entrepirse = c.Int(),
                        Name_Entrerise = c.String(),
                        Intro_Entreprise = c.String(),
                        NB_Employee = c.Int(),
                        Role = c.String(),
                        id_jobseeker = c.Int(),
                        First_Name = c.String(),
                        Last_Name = c.String(),
                        Intro_jobseeker = c.String(),
                        Date_of_birth = c.DateTime(precision: 7, storeType: "datetime2"),
                        Certif = c.String(),
                        Skills = c.String(),
                        Id_Project_Manager = c.Int(),
                        Role1 = c.String(),
                        Id_Entreprise_admin = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Entreprise_admin_Id_Account = c.Int(),
                        Entreprise_admin_Id_Account1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id_Account)
                .ForeignKey("dbo.Accounts", t => t.Entreprise_admin_Id_Account)
                .ForeignKey("dbo.Accounts", t => t.Entreprise_admin_Id_Account1)
                .Index(t => t.Entreprise_admin_Id_Account)
                .Index(t => t.Entreprise_admin_Id_Account1);
            
            CreateTable(
                "dbo.Job_Offer",
                c => new
                    {
                        Id_JobOffer = c.Int(nullable: false, identity: true),
                        job_title = c.String(),
                        Job_Description = c.String(),
                        Date_Offer = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Nbr_Candidat = c.Int(nullable: false),
                        Date_Expiration = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        visibility = c.Boolean(nullable: false),
                        Id_Entrepirse = c.Int(nullable: false),
                        Id_Project_Manager = c.Int(nullable: false),
                        Entreprise_admin_Id_Account = c.Int(),
                    })
                .PrimaryKey(t => t.Id_JobOffer)
                .ForeignKey("dbo.Accounts", t => t.Entreprise_admin_Id_Account)
                .ForeignKey("dbo.Accounts", t => t.Id_Entrepirse, cascadeDelete: true)
                .ForeignKey("dbo.Accounts", t => t.Id_Project_Manager, cascadeDelete: true)
                .Index(t => t.Id_Entrepirse)
                .Index(t => t.Id_Project_Manager)
                .Index(t => t.Entreprise_admin_Id_Account);
            
            CreateTable(
                "dbo.Applications",
                c => new
                    {
                        Id_JobOffer = c.Int(nullable: false),
                        id_jobseeker = c.Int(nullable: false),
                        Date_Application = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        State = c.Int(nullable: false),
                        Jobseeker_Id_Account = c.Int(),
                    })
                .PrimaryKey(t => new { t.Id_JobOffer, t.id_jobseeker })
                .ForeignKey("dbo.Job_Offer", t => t.Id_JobOffer, cascadeDelete: true)
                .ForeignKey("dbo.Accounts", t => t.Jobseeker_Id_Account)
                .Index(t => t.Id_JobOffer)
                .Index(t => t.Jobseeker_Id_Account);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id_Post = c.Int(nullable: false, identity: true),
                        Post = c.String(),
                        Date_Post = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Project_Manager_Id_Account = c.Int(),
                    })
                .PrimaryKey(t => t.Id_Post)
                .ForeignKey("dbo.Accounts", t => t.Project_Manager_Id_Account)
                .Index(t => t.Project_Manager_Id_Account);
            
            CreateTable(
                "dbo.Follows",
                c => new
                    {
                        Id_Entrepirse = c.Int(nullable: false),
                        id_jobseeker = c.Int(nullable: false),
                        Date_Follow = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Entreprise_admins_Id_Account = c.Int(),
                        Jobseekers_Id_Account = c.Int(),
                    })
                .PrimaryKey(t => new { t.Id_Entrepirse, t.id_jobseeker })
                .ForeignKey("dbo.Accounts", t => t.Entreprise_admins_Id_Account)
                .ForeignKey("dbo.Accounts", t => t.Jobseekers_Id_Account)
                .Index(t => t.Entreprise_admins_Id_Account)
                .Index(t => t.Jobseekers_Id_Account);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Follows", "Jobseekers_Id_Account", "dbo.Accounts");
            DropForeignKey("dbo.Follows", "Entreprise_admins_Id_Account", "dbo.Accounts");
            DropForeignKey("dbo.Accounts", "Entreprise_admin_Id_Account1", "dbo.Accounts");
            DropForeignKey("dbo.Accounts", "Entreprise_admin_Id_Account", "dbo.Accounts");
            DropForeignKey("dbo.Job_Offer", "Id_Project_Manager", "dbo.Accounts");
            DropForeignKey("dbo.Posts", "Project_Manager_Id_Account", "dbo.Accounts");
            DropForeignKey("dbo.Job_Offer", "Id_Entrepirse", "dbo.Accounts");
            DropForeignKey("dbo.Job_Offer", "Entreprise_admin_Id_Account", "dbo.Accounts");
            DropForeignKey("dbo.Applications", "Jobseeker_Id_Account", "dbo.Accounts");
            DropForeignKey("dbo.Applications", "Id_JobOffer", "dbo.Job_Offer");
            DropIndex("dbo.Follows", new[] { "Jobseekers_Id_Account" });
            DropIndex("dbo.Follows", new[] { "Entreprise_admins_Id_Account" });
            DropIndex("dbo.Posts", new[] { "Project_Manager_Id_Account" });
            DropIndex("dbo.Applications", new[] { "Jobseeker_Id_Account" });
            DropIndex("dbo.Applications", new[] { "Id_JobOffer" });
            DropIndex("dbo.Job_Offer", new[] { "Entreprise_admin_Id_Account" });
            DropIndex("dbo.Job_Offer", new[] { "Id_Project_Manager" });
            DropIndex("dbo.Job_Offer", new[] { "Id_Entrepirse" });
            DropIndex("dbo.Accounts", new[] { "Entreprise_admin_Id_Account1" });
            DropIndex("dbo.Accounts", new[] { "Entreprise_admin_Id_Account" });
            DropTable("dbo.Follows");
            DropTable("dbo.Posts");
            DropTable("dbo.Applications");
            DropTable("dbo.Job_Offer");
            DropTable("dbo.Accounts");
        }
    }
}

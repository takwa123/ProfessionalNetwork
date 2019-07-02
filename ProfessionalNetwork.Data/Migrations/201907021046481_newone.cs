namespace ProfessionalNetwork.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newone : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Project_Manager",
                c => new
                    {
                        Id_Project_Manager = c.Long(nullable: false, identity: true),
                        Role = c.String(),
                        Id_Entreprise_admin = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id_Project_Manager)
                .ForeignKey("dbo.Entreprise_admin", t => t.Id_Entreprise_admin, cascadeDelete: true)
                .Index(t => t.Id_Entreprise_admin);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id_Post = c.Long(nullable: false, identity: true),
                        Post = c.String(),
                        Date_Post = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Project_Manager_Id_Project_Manager = c.Long(),
                    })
                .PrimaryKey(t => t.Id_Post)
                .ForeignKey("dbo.Project_Manager", t => t.Project_Manager_Id_Project_Manager)
                .Index(t => t.Project_Manager_Id_Project_Manager);
            
            CreateTable(
                "dbo.Follows",
                c => new
                    {
                        Id_Entrepirse = c.Long(nullable: false),
                        id_jobseeker = c.Long(nullable: false),
                        Date_Follow = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => new { t.Id_Entrepirse, t.id_jobseeker })
                .ForeignKey("dbo.Entreprise_admin", t => t.Id_Entrepirse, cascadeDelete: true)
                .ForeignKey("dbo.Job_Seeker", t => t.id_jobseeker, cascadeDelete: true)
                .Index(t => t.Id_Entrepirse)
                .Index(t => t.id_jobseeker);
            
            AddColumn("dbo.Job_Seeker", "Entreprise_admin_Id_Entrepirse", c => c.Long());
            CreateIndex("dbo.Job_Seeker", "Entreprise_admin_Id_Entrepirse");
            AddForeignKey("dbo.Job_Seeker", "Entreprise_admin_Id_Entrepirse", "dbo.Entreprise_admin", "Id_Entrepirse");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Follows", "id_jobseeker", "dbo.Job_Seeker");
            DropForeignKey("dbo.Follows", "Id_Entrepirse", "dbo.Entreprise_admin");
            DropForeignKey("dbo.Posts", "Project_Manager_Id_Project_Manager", "dbo.Project_Manager");
            DropForeignKey("dbo.Project_Manager", "Id_Entreprise_admin", "dbo.Entreprise_admin");
            DropForeignKey("dbo.Job_Seeker", "Entreprise_admin_Id_Entrepirse", "dbo.Entreprise_admin");
            DropIndex("dbo.Follows", new[] { "id_jobseeker" });
            DropIndex("dbo.Follows", new[] { "Id_Entrepirse" });
            DropIndex("dbo.Posts", new[] { "Project_Manager_Id_Project_Manager" });
            DropIndex("dbo.Project_Manager", new[] { "Id_Entreprise_admin" });
            DropIndex("dbo.Job_Seeker", new[] { "Entreprise_admin_Id_Entrepirse" });
            DropColumn("dbo.Job_Seeker", "Entreprise_admin_Id_Entrepirse");
            DropTable("dbo.Follows");
            DropTable("dbo.Posts");
            DropTable("dbo.Project_Manager");
        }
    }
}

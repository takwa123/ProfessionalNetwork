namespace ProfessionalNetwork.Data.Migrations
{
    using ProfessionalNetwork.Domaine.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProfessionalNetwork.Data.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProfessionalNetwork.Data.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //try
            //{

            //    context.Entreprise_admins.Add(
            //    new Entreprise_admin
            //    {
            //        Name_Entrerise = "TunisiaDev",
            //        Intro_Entreprise = "Lorem ipsum dolor sit amet, consectetur adipiscing elit," +
            //        " sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." +
            //        " Ut enim ad minim veniam",
            //        NB_Employee = 10,
            //        Date_Created = DateTime.Now,
            //        Date_Deleted = DateTime.Now,
            //        Date_Modified = DateTime.Now,
            //        IsDeleted = false,
            //        Username = "Rouissi Wael",
            //        Email = "RouissiWael@gmailcom",
            //        Pwd = "Azerty",
            //        Enable = true,
            //        Photo = "image.png",
            //        Role = "Administrator",
            //    }
            //);
            //    context.JobSeekers.Add(
            //        new Jobseeker
            //        {
            //            First_Name = "Person",
            //            Last_Name = "Person",
            //            Intro_jobseeker = "Lorem ipsum dolor sit amet, consectetur adipiscing elit," +
            //            " sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." +
            //            " Ut enim ad minim veniam, quis nostrud",
            //            Date_of_birth = DateTime.Now,
            //            Certif = "c#,Asp.net,Java,Angular JS",
            //            Skills = "Soft Skills ,Hard Skills,",
            //            Date_Created = DateTime.Now,
            //            Date_Deleted = DateTime.Now,
            //            Date_Modified = DateTime.Now,
            //            IsDeleted = false,
            //            Username = "Rouissi Wael",
            //            Email = "RouissiWael@gmailcom",
            //            Pwd = "Azerty",
            //            Enable = true,
            //            Photo = "image.png",
            //        }
            //    );
            //   // context.Project_Managers.Add(
            //   //    new Project_Manager
            //   //    {
            //   //        Date_Created = DateTime.Now,
            //   //        Date_Deleted = DateTime.Now,
            //   //        Date_Modified = DateTime.Now,
            //   //        IsDeleted = false,
            //   //        Username = "Rouissi Wael",
            //   //        Email = "RouissiWael@gmailcom",
            //   //        Pwd = "Azerty",
            //   //        Enable = true,
            //   //        Photo = "image.png",
            //   //        EntrepirseFK = 1
            //   //    }
            //   //);
            //    context.Job_Offers.Add(
            //      new Job_Offer
            //      {
            //          job_title = "Developer JEE/Angular",
            //          Job_Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit," +
            //            " sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." +
            //            " Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris " +
            //            "nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit " +
            //            "in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
            //            "Excepteur sint occaecat cupidatat non proident," +
            //            " sunt in culpa qui officia deserunt mollit anim id est laborum",
            //          Date_Offer = DateTime.Now,
            //          Nbr_Candidat = 2,
            //          Date_Expiration = DateTime.Now,
            //          visibility = true,
            //          Date_Created = DateTime.Now,
            //          Date_Deleted = DateTime.Now,
            //          Date_Modified = DateTime.Now,
            //          IsDeleted = false,
            //          EntrepirseFK = 1,
            //         // Project_ManagerFK = 1,
            //      }
            //  );
            //    context.Applications.Add(
            //       new Application
            //       {
            //           Job_OfferFK = 1,
            //           Job_SeekerFK = 1,
            //           Date_Application = DateTime.Now,
            //           State = State_Application.Pending,
            //       }
            //   );
            //    context.Tests.Add(
            //         new Test
            //         {
            //             Nbr_Question = 5,
            //             Nbr_Point_Tolal = 100,
            //             Name_Test = "Test JEEAngularJS",
            //             Date_Created = DateTime.Now,
            //             Date_Deleted = DateTime.Now,
            //             Date_Modified = DateTime.Now,
            //             IsDeleted = false,
            //         }
            //    );
            //    context.Questions.Add(
            //        new Question
            //        {
            //            Content_Question = "Quelle méthode est appelée en premier à chaque appel d’une servlet?",
            //            Correct_AnswerID = 3,
            //            Point_Question = 10,
            //            Rank = 1,
            //            choice1 = "Start()",
            //            choice2 = "Run()",
            //            choice3 = "init()",
            //            TestFK = 1,
            //            Date_Created = DateTime.Now,
            //            Date_Deleted = DateTime.Now,
            //            Date_Modified = DateTime.Now,
            //            IsDeleted = false,
            //        }
            //   );
            //    context.Interviews.Add(
            //        new Interview
            //        {
            //            Date_Interview = DateTime.Now,
            //            Type_Interview = Enum_Type_Interview.Technical,
            //            State_interview = State_Application.Pending,
            //            TestFK = 1,
            //            Applciation_FK = 1,
            //            Date_Created = DateTime.Now,
            //            Date_Deleted = DateTime.Now,
            //            Date_Modified = DateTime.Now,
            //            IsDeleted = false,
            //        }
            //   );
            //    context.SaveChanges();
            //}
            //catch (DbEntityValidationException e)
            //{
            //    foreach (var eve in e.EntityValidationErrors)
            //    {
            //        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
            //            eve.Entry.Entity.GetType().Name, eve.Entry.State);
            //        foreach (var ve in eve.ValidationErrors)
            //        {
            //            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
            //                ve.PropertyName, ve.ErrorMessage);
            //        }
            //    }
            //    throw;
            //}
            //
        }
    }
}

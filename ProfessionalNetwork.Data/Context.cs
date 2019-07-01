﻿using ProfessionalNetwork.Data.Configurations;
using ProfessionalNetwork.Data.Conventions;
using ProfessionalNetwork.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Data
{
    public class Context: DbContext
    {



       public Context():base("PNdatabase")
        {

            }
       // public DbSet<Account> Accounts { get; set; }
        public DbSet<Entreprise_admin> Entreprise_admins { get; set; }
        public DbSet<Job_Offer> Job_Offers { get; set; }
        //public DbSet<Project_Manager> Project_Managers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Interview> Interviews { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Jobseeker> JobSeekers { get; set; }
        public DbSet<Test> Tests { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Add(new DateTimeConvention());
            modelBuilder.Configurations.Add(new EntrepriseConfiguration());
           // modelBuilder.Configurations.Add(new Project_ManagerConfiguration());
            modelBuilder.Configurations.Add(new ApplicationConfiguration());
            modelBuilder.Configurations.Add(new InterviewConfiguration());
            modelBuilder.Configurations.Add(new JobOfferConfiguration());
            modelBuilder.Configurations.Add(new QuestionConfiguration());
            modelBuilder.Configurations.Add(new TestConfiguration());
            modelBuilder.Configurations.Add(new JobSeekerConfiguration());

            
        }

    }
}

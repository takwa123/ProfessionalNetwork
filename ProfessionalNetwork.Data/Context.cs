using ProfessionalNetwork.Data.Configurations;
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



       public Context():base()
        {

            }
        public DbSet<Account> Account { get; set; }
        public DbSet<Entreprise_admin> Entreprise_admin { get; set; }
        public DbSet<Job_Offer> Job_Offers { get; set; }
        public DbSet<Project_Manager> Project_Manager { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Add(new DateTimeConvention());
            modelBuilder.Configurations.Add(new EntrepriseConfiguration());
            modelBuilder.Configurations.Add(new Project_ManagerConfiguration());
        }

    }
}

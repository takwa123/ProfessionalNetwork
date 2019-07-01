using ProfessionalNetwork.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Data.Configurations
{
    class Job_OfferConfiguration: EntityTypeConfiguration<Job_Offer>
    {
        public Job_OfferConfiguration()
        {
            HasRequired<Entreprise_admin>(s => s.Entreprise_Admins)
              .WithMany(t => t.Job_Offers)
              .HasForeignKey(u => u.Id_Entrepirse)
              .WillCascadeOnDelete(true);



            HasRequired<Project_Manager>(s => s.Project_Manager)
              .WithMany(t => t.Job_Offers)
              .HasForeignKey(u => u.Id_Project_Manager)
                .WillCascadeOnDelete(true);
        }
    }
}

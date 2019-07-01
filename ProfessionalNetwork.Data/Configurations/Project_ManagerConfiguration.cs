using ProfessionalNetwork.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Data.Configurations
{
    public class Project_ManagerConfiguration: EntityTypeConfiguration<Project_Manager>
    {
        public Project_ManagerConfiguration() {

            //HasRequired<Entreprise_admin>(s => s.Entreprise_admin)
            //      .WithMany(t => t.Project_Managers)
            //      .HasForeignKey(u => u.Id_Entreprise_admin)
            //      .WillCascadeOnDelete(true);

           

        }
    }
}

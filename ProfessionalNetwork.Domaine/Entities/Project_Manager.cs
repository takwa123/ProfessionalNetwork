using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Domaine.Entities
{
    public class Project_Manager : Account
    {
        [Key]
        public int Id_Project_Manager { get; set; }
     
        [DefaultValue("ProjectManager")]
        public string Role { get; set; }

        public ICollection<Job_Offer> Job_Offers { get; set; }
        public List<Posts> Posts { get; set; }
        public Entreprise_admin Entreprise_admins;
        public int Id_Entreprise_admin { get; set; }

    }
}

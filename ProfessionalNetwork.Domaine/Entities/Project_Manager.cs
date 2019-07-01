using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Domaine.Entities
{
    public class Project_Manager : Account
    {
        [Key]
        public long Id_Project_Manager { get; set; }
        public ICollection<Job_Offer> Job_Offers { get; set; }
    }
}

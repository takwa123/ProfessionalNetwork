using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Domaine.Entities
{
    public  class Entreprise_admin :Account
    {
        public string Name_Entrerise { get; set; }
        public string Intro_Entreprise { get; set; }
        public int NB_Employee { get; set; }
        [DefaultValue("Administrator")]
        public string Role { get; set; }
        public List<Project_Manager> Project_Managers { get; set; }
        public List<Jobseeker> Jobseekers { get; set; }
        public ICollection<Job_Offer> Job_Offers { get; set; }
    }
}

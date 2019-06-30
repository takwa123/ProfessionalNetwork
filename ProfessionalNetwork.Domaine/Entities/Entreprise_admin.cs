using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Domaine.Entities
{
    public  class Entreprise_admin
    {
        public int Id_Entrepirse { get; set; }
        public string Name_Entrerise { get; set; }
        public string Intro_Entreprise { get; set; }
        public int NB_Employee { get; set; }
        public string Activities { get; set; }

        public ICollection<Job_Offer> Job_Offers { get; set; }
    }
}

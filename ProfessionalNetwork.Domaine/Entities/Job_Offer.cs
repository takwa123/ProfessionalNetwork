using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Domaine.Entities
{
    public  class Job_Offer
    {
        public int Id_JobOffer { get; set; }
        public string job_title { get; set; }
        public string Job_Description { get; set; }
        public DateTime Date_Offer { get; set; }
        public int Nbr_Candidat { get; set; }
        public DateTime Date_Expiration { get; set; }


        public int Id_Entrepirse { get; set; }
        public Entreprise_admin Entreprise_admin { get; set; }
        public ICollection<Application> Applications { get; set; }
    }
}

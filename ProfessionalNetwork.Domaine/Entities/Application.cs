using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Domaine.Entities
{
    public  class Application
    {

        public DateTime Date_Application { get; set; }
        public string Response { get; set; }

        
        public int Id_JobOffer { get; set; }
        public Job_Offer Job_Offers { get; set; }

        public int id_jobseeker { get; set; }
        public Jobseeker Jobseeker { get; set; }


    }
}

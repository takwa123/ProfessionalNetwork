using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Domaine.Entities
{
    public class Job_Offers:Account 
    {
        public int Id_JobOffer { get; set; }
        public string job_title { get; set; }
        public string Job_Description { get; set; }
        public DateTime Date_Offer { get; set; }
        public int MyProperty { get; set; }
    }
}

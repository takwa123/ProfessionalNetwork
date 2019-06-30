using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Domaine.Entities

{
    public  class Follow
    {

        public DateTime  Date_Follow { get; set; }
        [Key, Column(Order = 0)]
        public int Entreprise_admin { get; set; }
        public Entreprise_admin Entreprise_admins { get; set; }
        [Key, Column(Order = 1)]
        public int Jobseeker { get; set; }
        public Jobseeker Jobseekers { get; set; }
    }
}

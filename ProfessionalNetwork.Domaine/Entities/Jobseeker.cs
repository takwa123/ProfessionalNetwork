using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Domaine.Entities
{
    public class Jobseeker
    {
        public int id__jobseeker { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Intro_jobseeker { get; set; }
        public string Certif { get; set; }
        public string Skills { get; set; }

        public List<Entreprise_admin> Entreprises { get; set; }
    }
}

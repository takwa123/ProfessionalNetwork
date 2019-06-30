using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Domaine.Entities
{
    public class Project_Manager
    {
        

        [DefaultValue("ProjectManager")]
        public string Role { get; set; }
        public List<Posts> Posts { get; set; }
        public int Entreprise_adminFK { get; set; }
        public Entreprise_admin iciunecle;

    }
}

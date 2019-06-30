using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Domaine.Entities

{
    public class Account
    {
        public int Id_Account { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Pwd { get; set; }
        public Boolean Enable { get; set; }
        public string Photo { get; set; }
    }
}

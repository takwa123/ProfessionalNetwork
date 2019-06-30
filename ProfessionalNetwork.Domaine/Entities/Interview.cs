using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Domaine.Entities
{
    public class Interview
    {
        public int Id_Interview { get; set; }
        public DateTime Date_Interview { get; set; }
        public Enum_Type_Interview Type_Interview { get; set; }
        public State_Application State_interview { get; set; }


        public int Id_Test { get; set; }
        public Test Test { get; set; }
    }
}

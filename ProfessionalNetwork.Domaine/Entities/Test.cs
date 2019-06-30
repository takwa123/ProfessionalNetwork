﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Domaine.Entities
{
    public class Test : EntityTrace
    {
        [Key]
        public int Id_Test { get; set; }

        public int Nbr_Question { get; set; }
        public int Nbr_Point_Tolal { get; set; }
        public int Name_Test { get; set; }

        public ICollection<Question> Questions { get; set; }

    }
}

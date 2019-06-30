﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Domaine.Entities
{
    public class Comments

    {
        [Key, Column(Order = 0)]
        public int id_jobseeker { get; set; }
        
        [Key, Column(Order = 1)]
        public int Id_Post { get; set; }
        
        public string Comment { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Date_Com { get; set; }

        public Jobseeker Jobseekers { get; set; }
        public Posts Posts { get; set; }
    }
}

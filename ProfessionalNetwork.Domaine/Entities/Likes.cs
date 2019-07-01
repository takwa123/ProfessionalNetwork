using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Domaine.Entities
{
    public class Likes
    {
        [Key, Column(Order = 0)]
        public long id_jobseeker { get; set; }
        public Jobseeker Jobseekers { get; set; }
        [Key, Column(Order = 1)]
        public int Id_Post { get; set; }
        public Posts Posts { get; set; }
        public Boolean Liked { get; set; }
    }
}

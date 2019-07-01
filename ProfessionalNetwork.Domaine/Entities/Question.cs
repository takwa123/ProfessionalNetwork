using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Domaine.Entities
{
    public class Question
    {

        public long Id_Question { get; set; }
        public string Content_Question { get; set; }
        public int Correct_AnswerID{ get; set; }
        public int Point_Question { get; set; }
        public int Rank { get; set; }



        [ForeignKey("Id_Test")]
        public int Id_Test { get; set; }
        public Test Test { get; set; }
    }
}

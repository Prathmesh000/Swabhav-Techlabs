using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Models
{
    internal class Professor
    {
        public int ProfessorId { get; set; }
        public string ProfessorName { get; set; }

        public Professor(int professorId, string professorName)
        {
            ProfessorId = professorId;
            ProfessorName = professorName;
        }   
    }
}

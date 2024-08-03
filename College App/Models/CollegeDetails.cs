using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Models
{
    internal class CollegeDetails
    {
        public int CollegeId { get; set; }
        public string CollegeName { get; set; }

        public List<Department> departments = new List<Department>();
        public List<Professor> professors = new List<Professor>();
        public List<Student> students = new List<Student>();

        public CollegeDetails(int id, string name)
        {
            CollegeId = id;
            CollegeName = name;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Models
{
    internal class Department
    {
        public int DepartmentId { get; set; } 
        public string DepartmentName { get; set; }

        public Department(int departmentId, string departmentName)
        {
            DepartmentId = departmentId;
            DepartmentName = departmentName;
        }
    }
}

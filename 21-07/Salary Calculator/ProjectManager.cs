using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Calculator
{
    internal class ProjectManager : Employee
    {
        public const double HUMANRESOURCEALLOWANCE = 0.5;
        public const double DIRECTALLOWANCE = 0.4;
        public const double TRAVELLINGALLOWANCE = 0.5;
        public double salary;

        public ProjectManager(int _employeeId, string _employeeName, double _basic) : base(_employeeId, _employeeName, _basic)
        {

        }
        public override double CalculateCTC()
        {

            salary = _basic + (HUMANRESOURCEALLOWANCE * _basic) + (DIRECTALLOWANCE * _basic) + (TRAVELLINGALLOWANCE * _basic);
            return salary;
        }
    }
}

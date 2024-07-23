using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Calculator
{
    internal class SoftwareDeveloper : Employee
    {
        public const double PERSONALALLOWANCE = 0.4;
        public const double TRAVELLINGALLOWANCE = 0.3;
        public double salary;
        public SoftwareDeveloper(int _employeeId, string _employeeName, double _basic) : base(_employeeId, _employeeName, _basic)
        {
        }

        public override double CalculateCTC()
        {

            salary = _basic + (PERSONALALLOWANCE * _basic) + (TRAVELLINGALLOWANCE * _basic);
            return salary;

        }
    }
}

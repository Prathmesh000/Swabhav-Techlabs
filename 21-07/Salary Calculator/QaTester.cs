using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Calculator
{
    internal class QaTester : Employee
    {
        public const double OVERTIME = 0.3;
        public double salary;

        public QaTester(int _employeeId, string _employeeName, double _basic) : base(_employeeId, _employeeName, _basic)
        {

        }
        public override double CalculateCTC()
        {
            salary = _basic + (OVERTIME * _basic);
            return salary;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Calculator
{
    abstract class Employee
    {
        private int _employeeId;
        private string _employeeName;
        protected double _basic;

        public Employee(int _employeeId, string _employeeName, double _basic)
        {
            this._employeeId = _employeeId;
            this._employeeName = _employeeName;
            this._basic = _basic;
        }

        public abstract double CalculateCTC();
    }
}

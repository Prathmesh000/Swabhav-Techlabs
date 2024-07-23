using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = {
                                    new SoftwareDeveloper(1, "George", 10000),
                                    new ProjectManager(2, "Washington", 20000),
                                    new QaTester(3, "Calver", 12000)
            };

            foreach (Employee employee in employees)
            {
                Print(employee);
            }

        }

        static void Print(Employee employee)
        {
            Console.WriteLine(employee.GetType().Name + " salary is: " + "\n" + employee.CalculateCTC());
            Console.WriteLine();
        }
    }

}

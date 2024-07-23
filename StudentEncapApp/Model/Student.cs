using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEncapApp.Model
{
    internal class Student
    {
        private int _studentRollNumber;
        private string _studentName;
        private float _studentCgpa;

        public int GetStudentRollNumber()
        {
            return _studentRollNumber;
        }

        public string GetStudentName()
        {
            return _studentName;
        }
        public float GetStudentCgpa()
        {
            return _studentCgpa;
        }
        public void SetStudentRollNumber(int studentRollNumber)
        {
            if (studentRollNumber > 0)
            {
                _studentRollNumber = studentRollNumber;
            }
            else
            {
                Console.WriteLine("Roll Number can't be Negative");
            }
        }

        public void SetStudentName(string studentName)
        {
            _studentName = (studentName.Length < 5) ? "" : studentName;

        }

        public void SetStudentCgpa(float studentCgpa)
        {
            if (1 <= studentCgpa && studentCgpa <= 10)
            {
                _studentCgpa = studentCgpa;
            }
            else
            {
                Console.WriteLine("Enter Valid CGPA");
            }
        }

        public double Percentage()
        {
            return _studentCgpa*9.5;
        }

    }
}

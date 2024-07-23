using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentEncapApp.Model;

namespace StudentEncapApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.SetStudentRollNumber(-1);
            student1.SetStudentName("sxb");
            student1.SetStudentCgpa(11);
            Console.WriteLine("Student name: " + student1.GetStudentName());
            Console.WriteLine();
          

            Student student2 = new Student();
            student2.SetStudentRollNumber(2);
            student2.SetStudentName("Aryan");
            student2.SetStudentCgpa(7);
            Console.WriteLine("Student roll number: " + student2.GetStudentRollNumber());
            Console.WriteLine("Student Name: " + student2.GetStudentName());
            Console.WriteLine("Student CGPA: " + student2.GetStudentCgpa());
            Console.WriteLine("Student Percentage: " + student2.Percentage());
        }
    }
}

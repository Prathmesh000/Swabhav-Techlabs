using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Models
{
    internal class MainMenu
    {
        public void Menu(CollegeDetails college, List<Student> students, List<Professor> professors, List<Department> departments)
        {


            Console.WriteLine("What operation do you want to perform??");
            Console.WriteLine();
            Console.WriteLine("1.Add New Student 2.Display All 3.Update Student Details 4.Delete Student 5.Add New Professor 6.Update Professor Details 7.Delete Professor 8.Exit");
            int userInput = int.Parse(Console.ReadLine());

            while (userInput != 8)
            {
                switch (userInput)
                {
                    case 1:
                        CreateStudent(college.students);
                        break;
                    case 2:
                        Display(college, college.students, college.professors, college.departments);
                        break;
                    case 3:
                        StudentUpdate(college.students);
                        break;
                    case 4:
                        StudentDelete(college.students);
                        break;
                    case 5:
                        AddProfessor(college.professors);
                        break;
                    case 6:
                        ProfessorUpdate(college.professors);
                        break;
                    case 7:
                        ProfessorDelete(college.professors);
                        break;
                    default:
                        Console.WriteLine("Select valid option.");
                        break;

                }
                Console.WriteLine();
                Console.WriteLine("What operation do you want to perform??");
                Console.WriteLine();
                Console.WriteLine("1.Add New Student 2.Display All 3.Update Student Details 4.Delete Student 5.Add New Professor 6.Update Professor Details 7.Delete Professor 8.Exit");
                userInput = int.Parse(Console.ReadLine());
            }

        }

        public void CreateStudent(List<Student> students)
        {
            Console.WriteLine();
            Console.WriteLine("Enter Student id: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Name: ");
            string name = Console.ReadLine();

            students.Add(new Student(id, name));
            Console.WriteLine("Student Added Successfully");
        }

        public void Display(CollegeDetails college, List<Student> students, List<Professor> professors, List<Department> departments)
        {
            Console.WriteLine();
            Console.WriteLine("College ID : " + college.CollegeId);
            Console.WriteLine("College Name : " + college.CollegeName);

            Console.WriteLine();

            Console.WriteLine("Number of students : " + students.Count);
            Console.WriteLine("Number of Professors : " + professors.Count);
            Console.WriteLine("Number of Departments : " + departments.Count);

            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine("Student Details");
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"|{"Student Id",-10} | {"Student Name",-15} |");
            foreach (Student student in students)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine($"|{student.StudentId,-10} | {student.StudentName,-15} |");
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine();

            Console.WriteLine("Professor Details");
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"|{"Professo Id",-12} | {"Professor Name",-15} |");
            foreach (Professor professor in professors)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine($"|{professor.ProfessorId,-12} | {professor.ProfessorName,-15} |");
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine();

            Console.WriteLine("Department Details");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"|{"Department Id",-15} | {"Department Name",-18} |");
            foreach (Department department in departments)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"|{department.DepartmentId,-15} | {department.DepartmentName,-18} |");
            }
            Console.WriteLine("---------------------------------------");
        }


        public void StudentUpdate(List<Student> students)
        {
            Console.WriteLine();
            Console.WriteLine("Enter Student Id: ");
            int userId = int.Parse(Console.ReadLine());
            bool flag = false;

            for (int iterator = 0; iterator < students.Count; iterator++)
            {
                if (students[iterator].StudentId == userId)
                {
                    Console.WriteLine("Enter Student Id: ");
                    int newId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Student Name: ");
                    string newName = Console.ReadLine();

                    students[iterator] = new Student(newId, newName);
                    Console.WriteLine("Student Details Updated Successfully");
                    flag = true;
                }
            }
            if (!flag)
            {
                Console.WriteLine("Id doesn't exist");
            }
        }

        public void StudentDelete(List<Student> students)
        {
            Console.WriteLine();
            Console.WriteLine("Enter Student Id: ");
            int userId = int.Parse(Console.ReadLine());
            bool flag = false;

            for (int iterator = 0; iterator < students.Count; iterator++)
            {
                if (students[iterator].StudentId == userId)
                {
                    students.RemoveAt(iterator);
                    Console.WriteLine("Student Details Deleted Successfully");
                    flag = true;
                }
            }
            if (!flag)
            {
                Console.WriteLine("ID doesn't exist");
            }
        }

        public void AddProfessor(List<Professor> professors)
        {
            Console.WriteLine();
            Console.WriteLine("Enter Professor id: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Professor Name: ");
            string name = Console.ReadLine();

            professors.Add(new Professor(id, name));
            Console.WriteLine("Professor Added Successfully");
        }

        public void ProfessorUpdate(List<Professor> professor)
        {
            Console.WriteLine();
            Console.WriteLine("Enter Professor Id: ");
            int userId = int.Parse(Console.ReadLine());
            bool flag = false;

            for (int iterator = 0; iterator < professor.Count; iterator++)
            {
                if (professor[iterator].ProfessorId == userId)
                {
                    Console.WriteLine("Enter Professor Id: ");
                    int newId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Professor Name: ");
                    string newName = Console.ReadLine();

                    professor[iterator] = new Professor(newId, newName);
                    Console.WriteLine("Professor Details Updated Successfully");
                    flag = true;
                }
            }
            if (!flag)
            {
                Console.WriteLine("Id doesn't exist");
            }
        }

        public void ProfessorDelete(List<Professor> professor)
        {
            Console.WriteLine();
            Console.WriteLine("Enter Professor Id: ");
            int userId = int.Parse(Console.ReadLine());
            bool flag = false;

            for (int iterator = 0; iterator < professor.Count; iterator++)
            {
                if (professor[iterator].ProfessorId == userId)
                {
                    professor.RemoveAt(iterator);
                    Console.WriteLine("Professor Details Deleted Successfully");
                    flag = true;
                }
            }
            if (!flag)
            {
                Console.WriteLine("ID doesn't exist");
            }
        }
    }
}


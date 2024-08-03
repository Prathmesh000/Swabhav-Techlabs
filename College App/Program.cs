
using System.Runtime.InteropServices;
using College.Models;

public class Program
{
    public static void Main(string[] args)
    {
        CollegeDetails college = new CollegeDetails(1, "D.M.C.E.");

        Department department1 = new Department(1, "C.S.");
        Department department2 = new Department(2, "I.T.");
        Department department3 = new Department(3, "M.E");
        Department department4 = new Department(4, "E.X.T.C.");
        college.departments.Add(department1);
        college.departments.Add(department2);
        college.departments.Add(department3);
        college.departments.Add(department4);

        Professor professor1 = new Professor(1001, "Dumbledore");
        Professor professor2 = new Professor(1002, "Severus Snape");
        Professor professor3 = new Professor(1003, "Trelawney");
        Professor professor4 = new Professor(1004, "Remus Lupin");
        college.professors.Add(professor1);
        college.professors.Add(professor2);
        college.professors.Add(professor3);
        college.professors.Add(professor4);

        Student student1 = new Student(101, "Harry");
        Student student2 = new Student(201, "Ron Weasley");
        Student student3 = new Student(301, "Neville");
        Student student4 = new Student(401, "Luna Lovegood");
        college.students.Add(student1);
        college.students.Add(student2);
        college.students.Add(student3);
        college.students.Add(student4);

        MainMenu menu = new MainMenu();
        menu.Menu(college, college.students, college.professors, college.departments);


    }

}

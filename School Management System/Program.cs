using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
             // Create the first Student
            Student student1 = new Student();
            student1.Name = "Ahmad";
            student1.Age = 18;
            student1.Grade = 90;
            student1.StudentId = 101;

            Console.WriteLine("First Student:");
            student1.DisplayInfo();
            student1.DisplayStudentInfo();

            Console.WriteLine();

            // Create the second Student
            Student student2 = new Student();
            student2.Name = "Sara";
            student2.Age = 17;
            student2.Grade = 95;
            student2.StudentId = 102;

            Console.WriteLine("Second Student:");
            student2.DisplayInfo();
            student2.DisplayStudentInfo();

            Console.WriteLine();

            // Create a Teacher
            Teacher teacher = new Teacher();
            teacher.Name = "Mr. Khaled";
            teacher.Age = 35;
            teacher.Subject = "Mathematics";

            Console.WriteLine("Teacher Information:");
            teacher.DisplayTeacherInfo();

            Console.WriteLine();

            // Create a SchoolReport
            SchoolReport report = new SchoolReport("Annual School Report");
            report.DisplayReportTitle();
        }
    }
}

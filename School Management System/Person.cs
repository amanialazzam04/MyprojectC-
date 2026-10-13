using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        protected string SchoolName { get; set; }


        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
           
        }
    }
    class Student : Person
    {
        public int  Grade { get; set; }
        public int StudentId { get; set; }
        public void DisplayStudentInfo()
        {
            DisplayInfo();
            Console.WriteLine($"School Name: {SchoolName}");
            Console.WriteLine($"Grade: {Grade}");
            Console.WriteLine($"Student ID: {StudentId}");
        }
    }

    class Teacher : Person
    {
        public string Subject { get; set; }

        private string internalCode;
        public void DisplayTeacherInfo()
        {
            DisplayInfo();
            Console.WriteLine($"School Name: {SchoolName}");
            Console.WriteLine($"Subject: {Subject}");
       
        }
        public Teacher() : base()
        {
            SchoolName = "ABC School";
        }



    }


    sealed class SchoolReport
    {
        public string ReportTitle { get; set; }

        public SchoolReport(string reportTitle)
        {
            ReportTitle = reportTitle;
        }

        public void DisplayReportTitle()
        {
            Console.WriteLine($"Report Title: {ReportTitle}");
        }

       
    }


}

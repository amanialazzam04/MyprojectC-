using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyprojectC_
{
    internal class Student
    {
        
        
            public string name;
            public int age;

        public double Grade;

            public Student(string studentName, int studentAge , double studentGrade)
            {
                name = studentName;
                age = studentAge;
                Grade = studentGrade;
            }

            public void DisplayInfo()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Grade: " + Grade);
            }
        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyprojectC_
{
   public class SystemSchoolTask3
    {
           public void Run()
            {
                // 1. Students Array
                string[] students =
                {
                "Ahmad", "Sara", "Omar", "Lina", "Yazan"
            };

                // 2. Student Grades
                int[] grades = { 85, 92, 68, 75, 90 };

                int choice;

                do
                {
                    Console.WriteLine("\n===== School System =====");
                    Console.WriteLine("1. Display Students");
                    Console.WriteLine("2. Search for Student");
                    Console.WriteLine("3. Check Student Result");
                    Console.WriteLine("4. Exit");
                    Console.Write("Enter your choice: ");

                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            // Display Students using for loop
                            Console.WriteLine("\n===== Students =====");

                            for (int i = 0; i < students.Length; i++)
                            {
                                Console.WriteLine(students[i]);
                            }

                            // Display Grades using foreach loop
                            Console.WriteLine("\n===== Grades =====");

                            foreach (int grade in grades)
                            {
                                Console.WriteLine(grade);
                            }

                            break;

                        case 2:
                            // Search for a Student using while loop
                            Console.Write("Enter student name: ");
                            string searchName = Console.ReadLine();

                            int index = 0;
                            bool found = false;

                            while (index < students.Length)
                            {
                                if (students[index].Equals(
                                    searchName,
                                    StringComparison.OrdinalIgnoreCase))
                                {
                                    Console.WriteLine("Student Found!");
                                    Console.WriteLine("Name: " + students[index]);
                                    Console.WriteLine("Grade: " + grades[index]);

                                    found = true;
                                    break;
                                }

                                index++;
                            }

                            if (!found)
                            {
                                Console.WriteLine("Student Not Found.");
                            }

                            break;

                        case 3:
                            // Check Student Result
                            Console.Write("Enter student's grade: ");
                            int studentGrade =
                                Convert.ToInt32(Console.ReadLine());

                            if (studentGrade < 0 || studentGrade > 100)
                            {
                                Console.WriteLine("Invalid grade. Enter 0-100.");
                            }
                            else if (studentGrade >= 90)
                            {
                                Console.WriteLine("Excellent");
                            }
                            else if (studentGrade >= 80)
                            {
                                Console.WriteLine("Very Good");
                            }
                            else if (studentGrade >= 70)
                            {
                                Console.WriteLine("Good");
                            }
                            else if (studentGrade >= 60)
                            {
                                Console.WriteLine("Pass");
                            }
                            else
                            {
                                Console.WriteLine("Fail");
                            }

                            break;

                        case 4:
                            Console.WriteLine("Goodbye!");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Try again.");
                            break;
                    }

                } while (choice != 4);
            }
        }
    }





using MyprojectC_;
using System;

class Program
{
    static void Main()
    {

     // GuessingGame game = new GuessingGame();
       
       //game.Play();


       
     //  SystemSchoolTask3 school = new SystemSchoolTask3();
         //school.Run();

      
            Student s1 = new Student("Sara", 20 ,80.5);
            Student s2 = new Student("Ahmad", 22 ,75.0);
            Student s3 = new Student("Lina", 19 ,85.5);

            s1.DisplayInfo();

            Console.WriteLine("   ");

            s2.DisplayInfo();

            Console.WriteLine(" ");

            s3.DisplayInfo();
        }


    }

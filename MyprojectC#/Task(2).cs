using System;

class Task2
{
    public static void Run()
    {
        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Student Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Student Grade: ");
        int grade = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Student Average: ");
        double average = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Student Gender: ");
        char gender = Convert.ToChar(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("===== Student Report =====");

        Console.WriteLine($"Welcome {name}!");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Gender: {gender}");

        Console.WriteLine();
        Console.WriteLine("===== Name Information =====");

        Console.WriteLine($"Original Name: {name}");
        Console.WriteLine($"Uppercase: {name.ToUpper()}");
        Console.WriteLine($"Lowercase: {name.ToLower()}");
        Console.WriteLine($"First Character: {name[0]}");

        double newAverage = average + 5;

        Console.WriteLine();
        Console.WriteLine("===== Average Calculation =====");

        Console.WriteLine($"Original Average: {average}");
        Console.WriteLine("Bonus Marks: 5");
        Console.WriteLine($"New Average: {newAverage}");

        bool passed = newAverage >= 50;
        bool adult = age >= 18;

        Console.WriteLine();
        Console.WriteLine("===== Student Status =====");

        Console.WriteLine($"New Average: {newAverage}");
        Console.WriteLine($"Passed: {passed}");
        Console.WriteLine($"Adult: {adult}");

        Console.WriteLine();
        Console.WriteLine("===== STUDENT SUMMARY =====");

        Console.WriteLine($"Welcome {name.ToUpper()}!");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"New Average: {newAverage}");
        Console.WriteLine($"Gender: {gender}");
        Console.WriteLine($"Result: {(passed ? "Passed" : "Failed")}");
        Console.WriteLine($"Adult: {adult}");
    }
}
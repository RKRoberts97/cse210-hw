using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your score? ");
        int score = int.Parse(Console.ReadLine()); // Parse input to an integer
        char grade;

        if (score >= 90)
        {
            grade = 'A';
        }
        else if (score >= 80)
        {
            grade = 'B';
        }
        else if (score >= 70)
        {
            grade = 'C';
        }
        else if (score >= 60)
        {
            grade = 'D';
        }
        else
        {
            grade = 'F';
        }

        Console.WriteLine($"You got a {grade}");
        if (score >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time! You can do it.");
        }
    }
}

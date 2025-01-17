using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is your magic number? ");
        Random randomGenerator = new Random();

        int magic = randomGenerator.Next(1, 21);
        int guess = magic + 1; 
        while (guess != magic) {
        Console.Write("What is your your guess? ");
        guess = int.Parse(Console.ReadLine());
        if (magic > guess){
            Console.WriteLine("Higher");
        }
        else if (magic < guess){
            Console.WriteLine("Lower");
        }
        else {
            Console.WriteLine("You guessed it!");
        }
        }

    }
}
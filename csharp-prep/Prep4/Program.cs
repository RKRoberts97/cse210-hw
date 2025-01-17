using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, enter 0 when done");
        int num = 1;
        List<int> numbers = new List<int>();
        
        while (num != 0)
        {
            Console.Write("Enter Number: ");
            num = int.Parse(Console.ReadLine());
            if (num != 0) 
            {
                numbers.Add(num);
            }
        }


        int total = 0;
        foreach (int numb in numbers)
        {
            total += numb;
        }
        Console.WriteLine($"Sum: {total}");


        int length = numbers.Count;
        if (length > 0)
        {
            double average = (double)total / length; 
            Console.WriteLine($"Average: {average}");
        }
        else
        {
            Console.WriteLine("Average: N/A (no numbers entered)");
        }

        if (numbers.Count > 0)
        {
            int max = numbers[0];
            foreach (int numb in numbers)
            {
                if (numb > max)
                {
                    max = numb;
                }
            }
            Console.WriteLine($"Max: {max}");
        }
        else
        {
            Console.WriteLine("Max: N/A (no numbers entered)");
        }
    }
}

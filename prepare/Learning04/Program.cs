using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment _stats = new MathAssignment("Russell Roberts", "Statistics", "Section 8.3", "Problems 8-14");
        WritingAssignment _history = new WritingAssignment("Russell Strober", "History", "How to end the world");
        Console.WriteLine(_stats.GetHomeworkList());
        Console.WriteLine(_history.GetWritingInformation());
    }
}
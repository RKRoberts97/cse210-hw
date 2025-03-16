
using System.Collections.Specialized;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class EternalGoal : Goal
    {


        public EternalGoal(string name, string desc, int points): base(name, desc, points)
        {
        }

    public override void Display()
    {
        Console.WriteLine($"{_name} - [ ] {_description} - {_points} points.");
    }

    public override void CompleteGoal()
    {
    }

    public override bool IsCompleted()
    {
        return false;
    }

}
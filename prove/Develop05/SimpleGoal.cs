
using System.Collections.Specialized;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class SimpleGoal : Goal
    {
        private bool _completed;

        public SimpleGoal(string name, string desc, int points): base(name, desc, points)
        {
            _completed = false;
        }

    public override void Display()
    {
        if (_completed == false)
        {
            Console.WriteLine($"{_name} - [ ] {_description} - {_points} points.");
        }
        else
        {
            Console.WriteLine($"{_name} - [X] {_description} - {_points} points.");
        }
    }

    public override void CompleteGoal()
    {
        _completed = true;
    }

    public override bool IsCompleted()
    {
        return _completed;
    }
    public override string ReturnDetails()
    {
        return base.ReturnDetails() + "," + _completed;
    }

}
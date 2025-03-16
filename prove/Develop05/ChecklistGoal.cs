
using System.Collections.Specialized;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class ChecklistGoal : Goal
    {
        private bool _completed;
        private int _numbercompleted;
        private int _totaltocomplete;
        private int _bonuspoints;

        public ChecklistGoal(string name, string desc, int points, int total, int bonus): base(name, desc, points)
        {
            _completed = false;
            _numbercompleted = 0;
            _bonuspoints = bonus;
            _totaltocomplete = total;
        }

    public override void Display()
    {
        if (_completed == false)
        {
            Console.WriteLine($"{_name} - [ ] {_description} - {_points} points, {_numbercompleted} / {_totaltocomplete}.");
        }
        else
        {
            Console.WriteLine($"{_name} - [X] {_description} - {_points} points, {_numbercompleted} / {_totaltocomplete}.");
        }
    }

    public override void CompleteGoal()
    {
        _numbercompleted = _numbercompleted + 1;
        if (_numbercompleted == _totaltocomplete)
        {
            _completed = true;
        }
    }

    public override bool IsCompleted()
    {
        return _completed;
    }

    public override int GivePoints()
    {
        if (IsCompleted() == false)
        {
            CompleteGoal();
            if (IsCompleted() == false)
            {
                return _points;
            }
            else
            {
                return _points + _bonuspoints;
            }
        }
        else
        {
            Console.WriteLine("You have already completed this goal!");
            return 0;
        }
    }
    public override string ReturnDetails()
    {
        return base.ReturnDetails() + "," + Convert.ToString(_numbercompleted) + "," + Convert.ToString(_totaltocomplete) + "," + Convert.ToString(_bonuspoints);
    }

}
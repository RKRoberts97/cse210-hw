
using System.Collections.Specialized;
using System.Runtime.CompilerServices;

public abstract class  Goal
    {
        protected string _name;
        protected string _description;
        protected int _points;

        public Goal(string name, string desc, int points)
        {
            _name = name;
            _description = desc;
            _points = points;
        }
        public abstract bool IsCompleted();

        public abstract void Display();

        public abstract void CompleteGoal();

        public virtual int GivePoints()
        {
            if (IsCompleted() == false)
            {
                CompleteGoal();
                return _points;
            }
            else
            {
                Console.WriteLine("You have already completed this goal!");
                return 0;
            }
        }
        public virtual string ReturnDetails()
        {
            return _name + "," + _description + "," + Convert.ToString(_points);
        }
        
        
    }
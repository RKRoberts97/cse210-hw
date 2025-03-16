using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    private List<Goal> _goals = new List<Goal>();
    private int _point_total = 0;

    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    public void Run()
    {
        string input = "";

        while (input != "6")
        {
            Console.WriteLine($"You have {_point_total} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    DisplayAll();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordGoal();
                    break;
                case "6":
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    public void DisplayAll()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to display.");
            return;
        }

        Console.WriteLine("The goals are:");
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.Write($"{i}. ");
            goal.Display();
            i++;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string desc = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = Convert.ToInt32(Console.ReadLine());

        Goal goal;

        switch (choice)
        {
            case "1":
                goal = new SimpleGoal(name, desc, points);
                break;
            case "2":
                goal = new EternalGoal(name, desc, points);
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int completes = Convert.ToInt32(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = Convert.ToInt32(Console.ReadLine());
                goal = new ChecklistGoal(name, desc, points, completes, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        _goals.Add(goal);
    }

    public void RecordGoal()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to record. Please create a goal first.");
            return;
        }

        DisplayAll();
        Console.Write("Which goal did you accomplish? ");
        int choice = Convert.ToInt32(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < _goals.Count)
        {
            int newPoints = _goals[choice].GivePoints();
            _point_total += newPoints;
            Console.WriteLine($"Congratulations! You have earned {newPoints} points!");
            Console.WriteLine($"You now have {_point_total} points.");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(_point_total);
                foreach (Goal goal in _goals)
                {
                    writer.WriteLine($"{goal.GetType().Name}|{goal.ReturnDetails()}");
                }
            }
            Console.WriteLine("Goals saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        try
        {
            if (!File.Exists(fileName))
            {
                Console.WriteLine("File not found.");
                return;
            }

            _goals.Clear(); // Remove old goals

            using (StreamReader reader = new StreamReader(fileName))
            {
                // Read the point total (first line)
                string pointsLine = reader.ReadLine();
                if (pointsLine != null)
                {
                    _point_total = int.Parse(pointsLine); // Could still cause an error, see below
                }

                // Read each goal (remaining lines)
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    string goalType = parts[0];
                    string[] details = parts[1].Split(',');

                    Goal goal = null;

                    if (goalType == "SimpleGoal")
                    {
                        // SimpleGoal:  name, description, points, isCompleted
                        if (details.Length == 4)
                        {
                            string name = details[0];
                            string description = details[1];
                            int points = int.Parse(details[2]); // Could cause an error
                            bool isCompleted = bool.Parse(details[3]); // Could cause an error

                            goal = new SimpleGoal(name, description, points);
                            if (isCompleted)
                            {
                                goal.CompleteGoal();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error reading SimpleGoal data.");
                        }
                    }
                    else if (goalType == "EternalGoal")
                    {
                        // EternalGoal: name, description, points
                    if (details.Length == 3)
                        {
                            string name = details[0];
                            string description = details[1];
                            int points = int.Parse(details[2]);  // Could cause an error
                            goal = new EternalGoal(name, description, points);
                        }
                        else
                        {
                            Console.WriteLine("Error reading EternalGoal data.");
                        }

                    }
                    else if (goalType == "ChecklistGoal")
                    {
                        // ChecklistGoal: name, description, points, timesCompleted, completeCount, bonus
                        if(details.Length == 6)
                        {
                            string name = details[0];
                            string description = details[1];
                            int points = int.Parse(details[2]); // Could cause an error
                            int timesCompleted = int.Parse(details[3]); // Could cause an error
                            int completeCount = int.Parse(details[4]);  // Could cause an error
                            int bonus = int.Parse(details[5]);  // Could cause an error

                            goal = new ChecklistGoal(name, description, points, completeCount, bonus);
                            for (int i = 0; i < timesCompleted; i++)
                            {
                                goal.CompleteGoal();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error reading Checklist data.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Unknown goal type: " + goalType);
                    }


                    if (goal != null)
                    {
                        _goals.Add(goal);
                    }
                }
            }

            Console.WriteLine("Goals loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading goals: " + ex.Message);
        }
    }
}
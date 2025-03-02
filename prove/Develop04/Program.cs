using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Activities Menu");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Imagery Activity");
            Console.WriteLine("5. Quit");
            Console.Write("Select an option (1-5): ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    RunBreathingActivity();
                    break;
                case "2":
                    RunReflectionActivity();
                    break;
                case "3":
                    RunListingActivity();
                    break;
                case "4":
                    RunImageryActivity();
                    break;
                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    PauseWithAnimation(2);
                    break;
            }
        }
    }

    static void RunBreathingActivity()
    {
        int duration = GetActivityDuration();
        BreathingActivity activity = new BreathingActivity(duration);
        activity.PerformActivity();
    }

    static void RunReflectionActivity()
    {
        int duration = GetActivityDuration();
        ReflectionActivity activity = new ReflectionActivity(duration);
        activity.PerformActivity();
    }

    static void RunListingActivity()
    {
        int duration = GetActivityDuration();
        ListingActivity activity = new ListingActivity(duration);
        activity.PerformActivity();
    }

    static void RunImageryActivity()
    {
        int duration = GetActivityDuration();
        ImageryActivity activity = new ImageryActivity(duration);
        activity.PerformActivity();
    }

    static int GetActivityDuration()
    {
        Console.Write("Enter the duration for the activity (in seconds): ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int duration) && duration > 0)
            {
                return duration;
            }
            Console.Write("Please enter a valid positive number: ");
        }
    }

    static void PauseWithAnimation(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write("/"); Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-"); Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write(@"\"); Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("|"); Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }
}

using System.Runtime.CompilerServices;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity(int duration) 
        : base("Listing Activity", 
               "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 
               duration)
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void PerformActivity()
    {
        Start();


        Console.WriteLine("Getting Started...");
        PauseWithAnimation(2);

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        Console.WriteLine("You will have a chance to list as many items as you can.");
        Console.WriteLine("Get ready...");


        PauseCountDown(5);


        List<string> userItems = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        
        Console.WriteLine("Start listing items (press Enter after each item):");

        while (DateTime.Now < endTime)
        {
            string? item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                userItems.Add(item);
            }
        }


        Console.WriteLine($"You listed {userItems.Count} items!");

        Pause(5);

        End();
    }
}

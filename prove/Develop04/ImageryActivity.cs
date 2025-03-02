using System.Runtime.CompilerServices;

public class ImageryActivity : Activity
{
    private List<string> _prompts;

    public ImageryActivity(int duration) 
        : base("Imagery Activity", 
               "This activity will help you clear your mind with a calming scene.", 
               duration)
    {
        _prompts = new List<string>
        {
            "Imagine a place where you feel calm",
            "Now imagine you are there with someone who makes you calm",
            "Imagine you have your favorite food there",
            "Imagine you are doing your favorite activity"
        };
    }

    public void PerformActivity()
    {
        Start();

        Console.WriteLine("Getting Started...");
        PauseWithAnimation(2);

        int sectionDuration = GetDuration() / _prompts.Count;  
        for (int i = 0; i < _prompts.Count; i++)
        {
            Console.WriteLine(_prompts[i]);
            PauseCountDown(sectionDuration);
        }

        End();
    }
}

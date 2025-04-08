public class Shark : Fish
{
    public Shark(string fishName, int baseValue) : base(fishName, baseValue) 
    {

    }
    
    public override void Display() {
        Console.WriteLine("(..       \\_    ,  |\\  /|");
        Console.WriteLine(" \\       O  \\  /|  \\ \\/ /");
        Console.WriteLine("  \\______    \\/ |   \\  / ");
        Console.WriteLine("     vvvv\\    \\ |   /  |");
        Console.WriteLine("     \\^^^^  ==   \\_/   |");
        Console.WriteLine("      `\\_   ===    \\.  |");
        Console.WriteLine("      / /\\_   \\ /      |");
        Console.WriteLine("      |/   \\_  \\|      /");
        Console.WriteLine("            \\________/");
    } 
    public override bool CatchCondition()
    {
        Random rand = new Random();
        int waitTime = rand.Next(1, 11); 
        string[] randomPunctuation = { "?!", "!?" }; 

        Console.WriteLine("Get ready...");

        for (int i = 0; i < waitTime; i++)
        {
            Thread.Sleep(1000);  
            Console.Write("... "); 

            
            if (rand.Next(3) == 0)  
            {
                Console.Write(randomPunctuation[rand.Next(randomPunctuation.Length)]);
            }
        }

        Console.Write("!!"); 

        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < 1)
        {
            if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
                Console.WriteLine($"\nCongrats on catching your {_fishName} ({_size}) worth {_value} points!");
                return true;
            }
        }

        Console.WriteLine("Better luck next time!");
        return false;
    }


}
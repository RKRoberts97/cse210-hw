public class Whale : Fish
{
    public Whale(string fishName, int baseValue) : base(fishName, baseValue) 
    {
        
    }
    
    public override void Display()
    {
        Console.WriteLine("       .");
        Console.WriteLine("      \":\"");
        Console.WriteLine("    ___:____     |\"\\/\"|");
        Console.WriteLine("  ,'        `.    \\  /");
        Console.WriteLine("  |  O        \\___/  |");
        Console.WriteLine("~^~^~^~^~^~^~^~^~^~^~^~^~");
    }
    public override string RandomizeSize(out double multiplier)
    {

        List<(string Size, double Multiplier)> sizes = new List<(string, double)>
        {
            ("Large", 1.5),
            ("Extra Large", 2.0)
        };

        Random rand = new Random();
        var chosenSize = sizes[rand.Next(sizes.Count)];

        multiplier = chosenSize.Multiplier;
        return chosenSize.Size;
    }
    public override bool CatchCondition()
    {
        Random rand = new Random();
        int waitTime = rand.Next(20, 31); 

        Console.WriteLine("Get ready...");

        for (int i = 0; i < waitTime; i++)
        {
            Thread.Sleep(1000);
            Console.Write("... ");
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
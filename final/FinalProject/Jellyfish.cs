public class Jellyfish : Fish
{
    public Jellyfish(string fishName, int baseValue) : base(fishName, baseValue)
    {

    }

    public override void Display()
    {
        Console.WriteLine("      _______");
        Console.WriteLine(" ,-~~~       ~~~-,");
        Console.WriteLine("(                 )");
        Console.WriteLine(" \\_-, , , , , ,-_/");
        Console.WriteLine("    / / | | \\ \\");
        Console.WriteLine("    | | | | | |");
        Console.WriteLine("    | | | | | |");
        Console.WriteLine("   / / /   \\ \\ \\");
        Console.WriteLine("   | | |   | | |");
    }

    public override bool CatchCondition()
    {
        Random rand = new Random();
        int waitTime = rand.Next(1, 4); 

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

public abstract class Fish
{
    public string _fishName;
    public int _value;
    public string _size;

    public Fish(string fishName, int baseValue)
    {
        _fishName = fishName;
        _size = RandomizeSize(out double multiplier); 
        _value = (int)(baseValue * multiplier); 
    }

    public abstract void Display();

    public virtual bool CatchCondition()
    {
        Random rand = new Random();
        int waitTime = rand.Next(1, 11); 

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

    public virtual string RandomizeSize(out double multiplier)
    {
        List<(string Size, double Multiplier)> sizes = new List<(string, double)>
        {
            ("Extra Small", 0.5),
            ("Small", 0.75),
            ("Medium", 1.0),
            ("Large", 1.5),
            ("Extra Large", 2.0)
        };

        Random rand = new Random();
        var chosenSize = sizes[rand.Next(sizes.Count)];

        multiplier = chosenSize.Multiplier;
        return chosenSize.Size;
    }

    public int GetValue() 
    {
        return _value;
    }
}

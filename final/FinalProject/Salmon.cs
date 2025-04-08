public class Salmon : Fish
{
    public Salmon(string fishName, int baseValue) : base(fishName, baseValue) 
    {
        
    }
    
    public override void Display()
    {
        Console.WriteLine("          /\"*._         _ ");
        Console.WriteLine("      .-*'`    `*-.._.-'/");
        Console.WriteLine("    < * ))     ,       ( ");
        Console.WriteLine("      `*-._`._(__.--*\"`.");

    }

}
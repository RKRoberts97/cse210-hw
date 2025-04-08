public class Seahorse : Fish
{
    public Seahorse(string fishName, int baseValue) : base(fishName, baseValue) 
    {
        
    }
    
    public override void Display()
    {
        Console.WriteLine("      \\/)/)");
        Console.WriteLine("    _'  oo(_.-. ");
        Console.WriteLine("  /'.     .---'");
        Console.WriteLine(" /'-./    (");
        Console.WriteLine(" )     ; __\\");
        Console.WriteLine(" \\_.'\\ : __|");
        Console.WriteLine("     )  _/");
        Console.WriteLine("    (  (,.");
        Console.WriteLine("     '-.-'");
    }

}
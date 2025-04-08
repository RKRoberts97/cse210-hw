public class Trout : Fish
{
    public Trout(string fishName, int baseValue) : base(fishName, baseValue) 
    {

    }
    
    public override void Display() {
        Console.WriteLine("  ;,//;,    ,;/");
        Console.WriteLine(" o:::::::;;///");
        Console.WriteLine(">::::::::;;\\\\\\");
        Console.WriteLine("  ''\\\\\\\\\\'\" ';");
    } 

}
public class Trout : Fish
{
    public Trout(string fishName, int value, string size) : base(fishName, value, size) 
    {

    }
    
    public override void Display() {
        Console.WriteLine($"Trout - Name: {FishName}, Value: {Value}, Size: {Size}");

    } 
    public override bool CatchCondition() 
    { 

        return true;
    }
}
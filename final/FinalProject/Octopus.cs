public class Octopus : Fish
{
    public Octopus(string fishName, int value, string size) : base(fishName, value, size) 
    {

    }
    
    public override void Display()
    {

    }
    public override bool CatchCondition() 
    {
        return true;
    }
}
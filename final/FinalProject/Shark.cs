public class Shark : Fish
{
    public Shark(string fishName, int value, string size) : base(fishName, value, size) 
    {

    }
    
    public override void Display(){

    }
    public override bool CatchCondition() 
    {
        return true;
    }
    public override void RandomizeSize()
    {

    }
}
public class GoldFish : Fish
{
    public GoldFish(string fishName, int value, string size) : base(fishName, value, size) {}
    
    public override void Display()
    {
        
    }
    public override bool CatchCondition()
    {
        return true;
    }
}
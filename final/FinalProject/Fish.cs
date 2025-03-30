public abstract class Fish
{
    public string FishName;
    public int Value;
    public string Size;

    
    public Fish(string fishName, int value, string size)
    {
        FishName = fishName;
        Value = value;
        Size = size;
    }
    
    public abstract void Display();
    public abstract bool CatchCondition();
    public virtual void RandomizeSize()
    {

    }
    public int GetValue() 
    {
        return 7;
    }
}
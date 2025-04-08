public class GoldFish : Fish
{
    public GoldFish(string fishName, int baseValue) : base(fishName, baseValue)
    {

    }

    public override void Display()
    {
        Console.WriteLine("><_>");
    }

    public override string RandomizeSize(out double multiplier)
    {
        List<(string Size, double Multiplier)> sizes = new List<(string, double)>
        {
            ("Extra Small", 2.0),
            ("Small", 1.5)
        };

        Random rand = new Random();
        var chosenSize = sizes[rand.Next(sizes.Count)];

        multiplier = chosenSize.Multiplier;
        return chosenSize.Size;
    }
}

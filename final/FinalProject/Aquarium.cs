public class Aquarium
{
    private List<Fish> fishes = new List<Fish>();

    public void AddFish(Fish fish)
    {
        fishes.Add(fish);
    }

    public void DisplayAllFishes()
    {
        foreach (var fish in fishes)
        {
            fish.Display();
        }
    }

    public int GetTotalValue()
    {
        int totalValue = 0;
        foreach (var fish in fishes)
        {
            totalValue += fish.Value;
        }
        return totalValue;
    }

    public Fish LookAtSpecificFish(string name)
    {
        Fish fish = fishes[0];
        return fish;
    }
}

public class Biome
{
    public string Name;
    private List<Fish> fishes = new List<Fish>();
    private List<int> chances = new List<int>();
    
    public Biome(string name)
    {
        Name = name;
    }
    
    public void AddFish(Fish fish, int chance)
    {
        fishes.Add(fish);
        chances.Add(chance);
    }
    
    public Fish GetFish()
    {

        return fishes[0];
    }
}
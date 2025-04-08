public class Biome
{
    public string Name;
    private List<Fish> _fishes = new List<Fish>();
    private List<int> _chances = new List<int>();

    public Biome(string name)
    {
        Name = name;
    }

    public void AddFish(Fish fish, int chance)
    {
        _fishes.Add(fish);
        _chances.Add(chance);
    }

    public Fish GetFish()
    {
        int totalWeight = _chances.Sum();
        Random rand = new Random();
        int randomNumber = rand.Next(1, totalWeight + 1);

        int cumulative = 0;
        for (int i = 0; i < _fishes.Count; i++)
        {
            cumulative += _chances[i];
            if (randomNumber <= cumulative)
            {
                return _fishes[i];
            }
        }

        return _fishes[0];
    }
}

using System.Formats.Asn1;
using System.Runtime.CompilerServices;

public class Aquarium
{
    private List<Fish> _fishes = new List<Fish>();

    public void AddFish(Fish fish)
    {
        _fishes.Add(fish);
    }

    public void DisplayAllFishes()
    {
        foreach (var fish in _fishes)
        {
            fish.Display();
        }
    }

    public int GetTotalValue()
    {
        int totalValue = 0;

        foreach (var fish in _fishes)
        {
            totalValue += fish.value;
        }

        return totalValue;
    }

    public void LookAtSpecificFish()
    {
        // Display all fish with a number
        Console.WriteLine("Here are the fishes in the aquarium:");

        for (int i = 0; i < _fishes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_fishes[i].fishName}");
        }

        // Ask the user to select a fish
        Console.Write("Enter the number of the fish you want to view: ");
        int response = Int32.Parse(Console.ReadLine());

        if (response >= 1 && response <= _fishes.Count)
        {
            // Display the selected fish
            Fish selectedFish = _fishes[response - 1];
            selectedFish.Display();
        }
        else
        {
            Console.WriteLine("Invalid input. Please select a valid number.");
        }
    }

    public void RemoveSpecificFish()
    {
        // Display all fish with a number
        Console.WriteLine("Here are the fishes in the aquarium:");

        for (int i = 0; i < _fishes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_fishes[i].fishName}");
        }

        // Ask the user to select a fish to remove
        Console.Write("Enter the number of the fish you want to remove: ");
        bool validInput = int.TryParse(Console.ReadLine(), out int response);

        // Validate the input and remove the fish if valid
        if (validInput && response >= 1 && response <= _fishes.Count)
        {
            // Get the selected fish and remove it from the list
            Fish selectedFish = _fishes[response - 1];
            _fishes.RemoveAt(response - 1); // Remove fish from the list
            Console.WriteLine($"The fish {selectedFish.fishName} has been removed.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please select a valid number.");
        }
    }
}

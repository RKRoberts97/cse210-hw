using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Menu();
    }

    public void Menu()
    {
        bool _exit = false;
        Aquarium _aquarium = new Aquarium();
        List<Biome> _biomes = CreateBiomes();

        while (!_exit)
        {
            Console.Clear(); // Clears the screen for each menu display
            Console.WriteLine("===== Fishing Game Menu =====");
            Console.WriteLine("1. How to Play");
            Console.WriteLine("2. Visit the Aquarium");
            Console.WriteLine("3. Go Fishing");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Hit enter as quickly as possible when you see two exclamation points (!!)");
                    break;
                case "2":
                    VisitAquarium(_aquarium);
                    break;
                case "3":
                    GoFishing(_aquarium, _biomes);
                    break;
                case "4":
                    _exit = true;
                    Console.WriteLine("Thanks for playing! Goodbye.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }

            if (!_exit)
            {
                Console.WriteLine("\nPress Enter to return to the menu...");
                Console.ReadLine();
            }
        }
    }

    public void VisitAquarium(Aquarium aquarium)
    {
        bool _exitAquarium = false;

        while (!_exitAquarium)
        {
            Console.Clear();
            Console.WriteLine("===== Aquarium Menu =====");
            Console.WriteLine("1. See Total Value of Fish");
            Console.WriteLine("2. Display All Fish");
            Console.WriteLine("3. View a Specific Fish");
            Console.WriteLine("4. Remove a Specific Fish");
            Console.WriteLine("5. Back to Main Menu");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine($"Total Value of Fish: {aquarium.GetTotalValue()}");
                    break;
                case "2":
                    aquarium.DisplayAllFishes();
                    break;
                case "3":
                    aquarium.LookAtSpecificFish();
                    break;
                case "4":
                    aquarium.RemoveSpecificFish();
                    break;
                case "5":
                    _exitAquarium = true; 
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }

            if (!_exitAquarium)
            {
                Console.WriteLine("\nPress Enter to return to the aquarium menu...");
                Console.ReadLine();
            }
        }
    }

    public List<Biome> CreateBiomes()
    {
        List<Biome> _biomes = new List<Biome>();

        Biome riverBiome = new Biome("River");
        riverBiome.AddFish(new Trout("Trout", 10), 50);
        riverBiome.AddFish(new Salmon("Coho Salmon", 12), 35);
        riverBiome.AddFish(new Trout("Sockeye Salmon", 25), 10);
        riverBiome.AddFish(new GoldFish("Abandoned Goldfish", 5), 5);
        _biomes.Add(riverBiome);

        Biome lakeBiome = new Biome("Lake");
        lakeBiome.AddFish(new Trout("Lake Trout", 14), 100); 
        _biomes.Add(lakeBiome);

        Biome beachBiome = new Biome("Beach");
        beachBiome.AddFish(new Jellyfish("Jellyfish", 8), 45); 
        beachBiome.AddFish(new GoldFish("Goldfish", 12), 35); 
        beachBiome.AddFish(new Octopus("Octopus", 25), 5); 
        beachBiome.AddFish(new Seahorse("Seahorse", 15), 15); 
        _biomes.Add(beachBiome);

        Biome oceanBiome = new Biome("Ocean");
        oceanBiome.AddFish(new Salmon("Atlantic Salmon", 5), 70); 
        oceanBiome.AddFish(new Octopus("Octopus", 20), 10); 
        oceanBiome.AddFish(new Whale("Whale", 50), 2); 
        oceanBiome.AddFish(new Shark("Tiger Shark", 17), 8); 
        oceanBiome.AddFish(new Shark("Great White Shark", 30), 5); 
        oceanBiome.AddFish(new Jellyfish("Boxer Jellyfish", 19), 5); 
        _biomes.Add(oceanBiome);

        return _biomes;
    }

    public void GoFishing(Aquarium aquarium, List<Biome> biomes)
    {
        Console.Clear();

        Console.WriteLine("Select a Biome to Fish In:");
        for (int i = 0; i < biomes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {biomes[i].Name}");
        }
        Console.Write("Enter the number of the biome you want to fish in: ");
        int biomeChoice = int.Parse(Console.ReadLine());

        if (biomeChoice >= 1 && biomeChoice <= biomes.Count)
        {
            Biome selectedBiome = biomes[biomeChoice - 1];
            Fish selectedFish = selectedBiome.GetFish(); 

            Console.WriteLine($"You are fishing in the {selectedBiome.Name} biome.");
            Console.WriteLine($"A {selectedFish._fishName} has appeared!");

            if (selectedFish.CatchCondition())
            {
                aquarium.AddFish(selectedFish); // Add the caught fish to the aquarium
                Console.WriteLine($"It has been added to your aquarium");
            }
        }
        else
        {
            Console.WriteLine("Invalid biome selection. Please try again.");
        }
    }
}

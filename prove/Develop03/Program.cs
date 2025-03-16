using System;
using System.Text.RegularExpressions;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int wordsToHide = 1; // Default to easy mode

        // Difficulty selection
        while (true)
        {
            Console.Write("Select difficulty (easy/medium/hard): ");
            string difficulty = Console.ReadLine().Trim().ToLower();

            if (difficulty == "easy")
            {
                wordsToHide = 1;
                break;
            }
            else if (difficulty == "medium")
            {
                wordsToHide = 3;
                break;
            }
            else if (difficulty == "hard")
            {
                wordsToHide = 5;
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 'easy', 'medium', or 'hard'.");
            }
        }


            Scripture scripture = new Scripture("1 Nephi 3:7", "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetScripture());
                Console.WriteLine("\nPress Enter to hide words, or type 'exit' to quit.");

                string input = Console.ReadLine();
                if (input.ToLower() == "exit") 
                {
                    Console.WriteLine("Goodbye!");
                    return;
                }

                if (scripture.CheckDone())
                {
                    Console.WriteLine("\nAll words are hidden. Program ending...");
                    return;
                }

                scripture.HideWords(wordsToHide);
            }
        }
    }





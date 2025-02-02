
using System.Runtime.CompilerServices;

public class Entry
    {
        // The C# convention is to start member variables with an underscore _
        public string _date = "";
        public string _prompt = "";

        public string _text = "";

        public string _entry = "";




        public void Display()
        {
            Console.WriteLine($"{_entry}");

        }
        public void CreateEntry()
        {
            // Get the current date 
            DateTime theCurrentTime = DateTime.Now;
            _date = theCurrentTime.ToShortDateString();

            // Get a new prompt
            PromptManager _prompts = new PromptManager();
            _prompt = _prompts.GetRandPrompt();

            //Get a response
            Console.WriteLine($"{_prompt}");
            _text = Console.ReadLine();

            // Compile entry into a proper format
            _entry = "Date: " + _date + " Prompt: " + _prompt + "\n" + _text + "\n ";


        }
    }
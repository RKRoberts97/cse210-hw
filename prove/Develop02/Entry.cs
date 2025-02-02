
using System.Runtime.CompilerServices;

public class Entry
    {
        // The C# convention is to start member variables with an underscore _
        public string _date = "";
        public string _prompt = "";

        public string _text = "";

        public string _entry = "";

        string _border = "----------------------------------------------------------------------------------------------------";




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
            _entry = _border + "\n" + "Date: " + _date + " Prompt: " + _prompt + "\n" + _text + "\n" + _border + "\n";


        }
        public void ChangeBorder()
        {
            Console.WriteLine("What symbol do you want to border your entries?");
            string _symbol = Console.ReadLine();
            int i = 0;
            _border = "";
            while (i < 101 ){
                _border = _border + _symbol;
                i++;
            }
        }
    }
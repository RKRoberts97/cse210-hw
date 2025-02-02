
using System.Runtime.CompilerServices;

public class PromptManager
    {
        // The C# convention is to start member variables with an underscore _
        public List<string> _prompts = new List<string> {"What cool things happened today?", "How did you see the hand of God in your life today?", "What was hard today?", "Why did you do what you did today?"};

        Random _rnd = new Random();

        


        public string GetRandPrompt()
        {
            int _r = _rnd.Next(_prompts.Count);
            return _prompts[_r];

        }
    }
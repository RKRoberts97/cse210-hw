
using System.Runtime.CompilerServices;

public class ReflectionActivity : Activity
    {
        private List<string> _prompts;
        private List<string> _reflection;

        public ReflectionActivity(int duration) : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", duration) 
        {
            _prompts = new List<string> 
            {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you helped someone in need."
            };
            _reflection = new List<string>
            {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };

        }
        public void PerformActivity()
        {
            Start();


            Random random = new Random();
            string startingPrompt = _prompts[random.Next(_prompts.Count)];

            Console.WriteLine("Getting Started...");
            PauseWithAnimation(2);

            Console.WriteLine(startingPrompt);
            Console.WriteLine("Take a moment to think about this prompt.");
            Console.WriteLine("Press Enter when you are ready to reflect...");
            Console.ReadLine();

            int remainingTime = GetDuration();

            while (remainingTime > 0)
            {
                string reflectionQuestion = _reflection[random.Next(_reflection.Count)];
                Console.Write(reflectionQuestion);

                if   (remainingTime >= 4)
                {
                    PauseWithAnimation(4);
                    Console.WriteLine("");
                    remainingTime -= 4;

                }
                else 
                {
                    PauseWithAnimation(remainingTime);
                    Console.WriteLine("");
                    remainingTime -= remainingTime;

                }
                
            }

            End();
        }

        
    }
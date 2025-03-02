
using System.Collections.Specialized;
using System.Runtime.CompilerServices;

public class Activity
    {
        private string _name;
        private string _description;
        private int _duration;
        private int _runtime;

        public Activity()
        {
            _name = "";
            _description = "";
            _duration = 0;
            _runtime = 0;
        }
        public Activity(string name, string desciption, int duration)
        {
            _name = name;
            _description = desciption;
            _duration = duration;
            _runtime = 0;
        }
        public int GetDuration()
        {
            return _duration;
        }
        
        public void Start()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_name}.");
            Console.WriteLine("");
            Console.WriteLine(_description);
            PauseWithAnimation(3);
            Console.Clear();


        }
        public void PauseCountDown(int duration)
        {
            while (duration != 0)
            {
                Console.Write(duration);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                duration = duration - 1;

            }
            

        }
        public void PauseAnimation()
        {
            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("\u2012"); 
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write(@"\"); 
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("|"); 
            Thread.Sleep(200);
            Console.Write("\b \b");

        }
        public void Pause(int duration)
        {
            Thread.Sleep(duration*1000);
        }
        public void PauseWithAnimation(int duartion)
        {
            DateTime endTime = DateTime.Now.AddSeconds(duartion);
            while (DateTime.Now < endTime)
            {
                PauseAnimation();
            }
        }
        public void End()
        {
            Console.Clear();
            Console.WriteLine("Well Done!");
            PauseWithAnimation(3);
            Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
            PauseWithAnimation(3);

        }


        
    }
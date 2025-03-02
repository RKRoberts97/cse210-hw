
using System.Runtime.CompilerServices;

public class BreathingActivity : Activity
    {


        public BreathingActivity(int duration) : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", duration)
        {
            

        }
        public void PerformActivity()
        {
            Start();  

            Console.WriteLine("Getting Started...");
            PauseWithAnimation(2);

            int remainingTime = GetDuration();  

            while (remainingTime > 0)
            {
                if (remainingTime >= 6)
                {
                    Console.WriteLine("Breathe In...");
                    PauseCountDown(6);
                    remainingTime -= 6;
                }
                else
                {
                    Console.WriteLine("Breathe In...");
                    PauseCountDown(remainingTime);
                    break;
                }

                if (remainingTime >= 4)
                {
                    Console.WriteLine("Breathe Out...");
                    PauseCountDown(4);
                    remainingTime -= 4;
                }
                else
                {
                    Console.WriteLine("Breathe Out...");
                    PauseCountDown(remainingTime);
                    break;
                }
            }

            End();  
        }


        
    }

using System.Runtime.CompilerServices;

public class Resume
    {
        // The C# convention is to start member variables with an underscore _
        public string _name = "";
        public List<Job> _jobs = new List<Job>();




        public void Display()
        {
            Console.WriteLine("Name:");
            Console.WriteLine($"{_name}");
            Console.WriteLine("Jobs:");
            foreach (var job in _jobs){
                job.Display();
            }

        }
    }
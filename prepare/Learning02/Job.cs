
    public class Job
    {
        // The C# convention is to start member variables with an underscore _
        public string _company = "";
        public string _jobTitle = "";

        public int _startyear;

        public int _endyear;



        public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_company}), {_startyear}-{_endyear}");
        }
    }
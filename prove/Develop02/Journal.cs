
using System.Runtime.CompilerServices;

public class Journal
    {
        // The C# convention is to start member variables with an underscore _

        public List<Entry> _entries = new List<Entry>();





        public void Display()
        {
            foreach (var entry in _entries){
                entry.Display();
            }

        }

        public void Save(string filename)
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach (var entry in _entries){
                        outputFile.WriteLine($"{entry._entry}");
                    }                 
                    
                    
                }          
        }

        public void Load(string filename)
        {
            _entries = new List<Entry>();
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                Entry _entry = new Entry();
                _entry._entry = line;
                _entries.Add(_entry);
                
            }

        }
        public void AddEntry()
        {
            Entry _new_entry = new Entry();
             
            Console.WriteLine("Would you liek a different border?");
            Console.Write("Enter 1 if yes: ");
            string _border_check = Console.ReadLine();
            if ( _border_check =="1" ){
                _new_entry.ChangeBorder();
            }

            _new_entry.CreateEntry();
            _entries.Add(_new_entry);
        }

    }
using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Journal _journal = new Journal();
        Menu _menu = new Menu();
        string _menu_selection = "0";

        
        while ( _menu_selection != "5" ){
            _menu.Display();
            Console.WriteLine("");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("");
            _menu_selection = Console.ReadLine();
            if ( _menu_selection == "1") {
                _journal.AddEntry();
            }
            if ( _menu_selection == "2") {
                _journal.Display();
            }
            if ( _menu_selection == "3") {
                Console.WriteLine("What would you like to name your file?");
                string filename = Console.ReadLine();
                _journal.Save(filename);
            }
            if ( _menu_selection == "4") {
                Console.WriteLine("What file would you like to load?");
                string filename = Console.ReadLine();
                _journal.Load(filename);
            }
            if ( _menu_selection =="5") {
                
            }
            else {
                Console.WriteLine("Not a valid option");
            }


        }






        
    }

}
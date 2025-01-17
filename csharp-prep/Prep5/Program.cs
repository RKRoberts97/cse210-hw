using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string name = PromptUserName();
        int num = PromptUserNumber();
        int sq = SquareNumber(num);
        DisplayResult(name, sq);
    }
    static void DisplayMessage(){
        Console.WriteLine("Welcome to the Program");
    }
    static string PromptUserName(){
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber(){
        Console.Write("Enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }
    static int SquareNumber(int num){
        int sq = num*num;
        return sq;
    }
    static void DisplayResult(string name, int sq){
        Console.WriteLine($"{name}, the square of your favorite number is {sq}.");
    }
}
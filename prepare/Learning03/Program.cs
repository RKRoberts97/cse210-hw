using System;

class Program
{
    static void Main(string[] args)
    {
        
        Fraction _nada = new Fraction();
        Console.WriteLine(_nada.GetFractionString());
        Console.WriteLine(_nada.GetDecimalValue());
        Fraction _uno = new Fraction(1);
        Console.WriteLine(_uno.GetFractionString());
        Console.WriteLine(_uno.GetDecimalValue());
        Fraction _three_forths = new Fraction(3, 4);
        Console.WriteLine(_three_forths.GetFractionString());
        Console.WriteLine(_three_forths.GetDecimalValue());
    }
}
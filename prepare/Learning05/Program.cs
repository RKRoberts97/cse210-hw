using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> _shapes = new List<Shape>();
        _shapes.Add(new Rectangle("blue", 8, 9));
        _shapes.Add(new Circle("red", 3));
        _shapes.Add(new Square("green", 9));
        foreach (Shape item in _shapes)
        {
            Console.WriteLine(item.GetColor());
            Console.WriteLine(item.GetArea());
        }

    }
}
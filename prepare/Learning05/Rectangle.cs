
using System.Collections.Specialized;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Rectangle : Shape
    {
        private double _length;
        private double _width;

        public Rectangle(string color, double length, double width)
        {
            SetColor(color);
            _length = length;
            _width = width;
        }
        

        public override double GetArea()
        {
            return _length*_width;
        }



        
    }
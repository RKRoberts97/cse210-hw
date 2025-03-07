
using System.Collections.Specialized;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Square : Shape
    {
        private double _side;

        public Square(string color, double side)
        {
            SetColor(color);
            _side = side;

        }
        

        public override double GetArea()
        {
            return _side*_side;
        }



        
    }
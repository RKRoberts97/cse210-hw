
using System.Collections.Specialized;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Circle : Shape
    {
        private double _radius;

        public Circle(string color, double radius)
        {
            SetColor(color);
            _radius = radius;

        }
        

        public override double GetArea()
        {
            return _radius*_radius*3.14;
        }



        
    }
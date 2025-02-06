
using System.Runtime.CompilerServices;

public class Fraction
    {
        private int _top;
        private int _bottom;

        public Fraction()
        {
            _top = 0;
            _bottom = 1;

        }
        public Fraction(int wholeNumber)
        {
            _top = wholeNumber;
            _bottom = 1;

        }
        public Fraction(int top, int bottom)
        {
            _top = top;
            _bottom = bottom;

        }


        public int GetTop()
        {
            return _top;
        }
        public int GetBottom()
        {
            return _bottom;
        }
        public void SetTop(int top)
        {
            _top = top;
        }
        public void SetBottom(int bottom)
        {
            _bottom = bottom;
        }
        public string GetFractionString()
        {
            return Convert.ToString(_top) + "/" + Convert.ToString(_bottom);
        }
        public double GetDecimalValue()
        {
            return Convert.ToDouble(_top)/Convert.ToDouble(_bottom);
        }

    }
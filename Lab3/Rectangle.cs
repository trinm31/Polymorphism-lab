using System;


namespace Lab3
{
    public class Rectangle: Shape
    {
        private double _height;
        private double _wide;
        public Rectangle(double h, double w)
        {
            this._height = h;
            this._wide = w;
        }

        public override double CalculatePerimeter()
        {
            return (_height + _wide) * 2;
        }

        public override double CalculateArea()
        {
            return _height * _wide;
        }

        public override string Draw()
        {
            string result = "";
            int i, j; 
            for (i = 1; i <= _wide; i++) 
            { 
                for (j = 1; j <= _height; j++)
                {
                    if (i == 1 || i == _wide ||
                        j == 1 || j == _height)
                        result += "*";
                    else
                        result += " ";
                } 
                result+= "\n"; 
            }
            return result;
        }
    }
}


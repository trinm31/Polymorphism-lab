using System;

namespace Lab3
{
    public class Circle : Shape
    {
        private double _radius;

        public Circle()
        {

        }

        public Circle(double radius)
        {
            this._radius = radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * _radius * Math.PI;
        }

        public override double CalculateArea()
        {
            return _radius * _radius * Math.PI;
        }

        public override string Draw()
        {
            string result ="";
            double dist;
            for (int i = 0; i <= 2 * _radius; i++)
            {


                for (int j = 0; j <= 2 * _radius; j++)
                {
                    dist = Math.Sqrt((i - _radius) *
                        (i - _radius) + (j - _radius)
                        * (j - _radius));

                    if (dist > _radius - 0.5 &&
                        dist < _radius + 0.5)
                        result +="*";
                    else
                        result +=" ";
                }

                result += "\n";
            }

            return result;
        }
    }
}
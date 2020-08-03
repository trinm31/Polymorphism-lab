using System;

namespace Lab3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(3, 4);
            Circle circle =new Circle(5);
            Console.WriteLine(rectangle.CalculatePerimeter());
            Console.WriteLine(rectangle.CalculateArea());
            Console.WriteLine(circle.CalculatePerimeter());
            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(rectangle.Draw());
            Console.WriteLine(circle.Draw());
        }
    }
}
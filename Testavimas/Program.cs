using System;

namespace Testavimas
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Console.WriteLine("test");
            Console.WriteLine(circle.getPerimetras());
            Console.WriteLine(circle.getPlotas());
        }
    }
}

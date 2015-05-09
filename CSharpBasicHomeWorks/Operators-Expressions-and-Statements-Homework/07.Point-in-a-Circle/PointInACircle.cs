using System;

    class PointInACircle
    {
        static void Main(string[] args)
        {

            double raduis = 2;

            Console.WriteLine("Enter X coordinate");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Y coordinate");
            double y = double.Parse(Console.ReadLine());

            double point = Math.Sqrt((x * x) + (y * y));

            Console.WriteLine(point <= raduis ? "The Point is IN the Circle" : "The Point is OUT of the Circle");
        }
    }


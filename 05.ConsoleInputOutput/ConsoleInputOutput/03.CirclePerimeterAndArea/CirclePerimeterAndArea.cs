using System;

    class CirclePerimeterAndArea
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter radius : ");
        double radius = double.Parse(Console.ReadLine());

        double area = Math.PI * (radius * radius);
        double perimeter =  (2 * Math.PI *  radius);
        Console.WriteLine("area = {0:f2}\nperimeter = {1:f2}", area, perimeter);
    }
}


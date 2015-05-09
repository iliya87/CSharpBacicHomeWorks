using System;


class Rectangles
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter rectangle's Width:");
        decimal width = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter rectangle's Height:");
        decimal height = decimal.Parse(Console.ReadLine());

        decimal perimeter = (width + height) * 2;
        decimal area = width * height;

        Console.WriteLine("Rectangle's perimeter is: {0} and the area is: {1}" , perimeter, area);
    }
}


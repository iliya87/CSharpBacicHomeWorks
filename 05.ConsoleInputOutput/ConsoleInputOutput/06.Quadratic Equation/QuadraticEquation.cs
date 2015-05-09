using System;

class QuadraticEquation
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter coefficient of a :");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter coefficient of b :");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter coefficient of c :");
        double c = double.Parse(Console.ReadLine());

        
        double discriminant = (b * b) - 4 * a * c;

        if (discriminant < 0)
        {
            
            Console.WriteLine("There are no real roots");
        }
        else
        {
            
            double discriminantRoot = Math.Sqrt(discriminant);
            double x1 = (-b + discriminantRoot) / (2 * a);
            double x2 = (-b - discriminantRoot) / (2 * a);
            Console.WriteLine(x1 == x2 ? "The Equasion got one real root {0}" : "The Equasion got two real roots {0} {1}", x1, x2);
        }
    }

}
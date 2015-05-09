using System;


    class SumOfNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number :");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter Second number:");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter Third number :");
        double c = double.Parse(Console.ReadLine());

        double sum = a + b + c;

        Console.WriteLine("The sum of numbers : {0}", sum);
    }
}


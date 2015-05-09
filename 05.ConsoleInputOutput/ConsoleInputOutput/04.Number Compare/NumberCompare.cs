using System;


    class NumberCompare
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number : ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number :");
            double b = double.Parse(Console.ReadLine());

            double greater = Math.Max(a, b);

            Console.WriteLine("The greater number is : {0} ", greater);


        }
    }


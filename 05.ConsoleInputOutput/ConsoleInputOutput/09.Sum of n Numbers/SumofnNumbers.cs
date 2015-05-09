using System;

    class SumOfNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many numbers you will enter :  ");

            double n = double.Parse(Console.ReadLine());
            double sum = 0;

            for (double i = 0; i < n; i++)
            {
                Console.WriteLine("Enter a Number : ");
                double value = double.Parse(Console.ReadLine());
                sum += value;

            }
            Console.WriteLine("The sum of the {0} numbers is {1}", n, sum);  
        }
    }


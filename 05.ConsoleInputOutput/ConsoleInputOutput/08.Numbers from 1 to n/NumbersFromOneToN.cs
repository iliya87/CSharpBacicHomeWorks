using System;



    class NumbersFromOneToN
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number (greater than 1): ");
            uint number = uint.Parse(Console.ReadLine());

            Console.Write("\nAll numbers in interval [1;{0}]: ", number);
            for (int i = 1; i <= number; i++)
            {
                Console.Write(i + (i < number ? ", " : "\n\n"));
            }
        }
    }


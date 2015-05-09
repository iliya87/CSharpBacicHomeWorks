using System;


class PrimeNumberCheck
{
    static void Main(string[] args)
    {
             Console.WriteLine("Enter some number to 100 ");
             int number = int.Parse(Console.ReadLine());

            bool isPrime = ((number % 2 > 0)
            && (number % 3 > 0) && (number % 5 > 0)
            && (number % 7 > 0)) || ((number == 2) || (number == 3)
            || (number == 5) || (number == 7));

             Console.WriteLine(isPrime);
    }
}


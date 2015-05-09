using System;


class OddOrEven
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter some number :");
        int n = int.Parse(Console.ReadLine());

        bool somenumb = n % 2 == 0;

        Console.WriteLine("The number is {0}",somenumb ? "EVEN" : "ODD" );
    }
}


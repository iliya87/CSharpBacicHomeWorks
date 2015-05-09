using System;

class NumbersFromOneToN
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter positive integer :");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write(" {0} ",i );
        }
    }
}


using System;


class NotDivisibleByThreeAndSeven
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter positive integer :");

       int n = int.Parse(Console.ReadLine());

       for (int i = 1; i <= n; i++)
       {
           if (i % 3 == 0 || i % 7 == 0)
           {
               continue;
           }
           Console.Write("{0} ", i);
       }
    }
}


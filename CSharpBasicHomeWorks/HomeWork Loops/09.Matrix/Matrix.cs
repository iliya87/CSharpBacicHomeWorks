using System;

class Matrix
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number [1-19]");

        int n = int.Parse(Console.ReadLine());

        if (n > 0 && n < 20)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int coll = 0; coll < n; coll++)
                {
                    Console.Write("{0,2} ", coll + row);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("The number is too big");
        }
    }
}


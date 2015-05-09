using System;

class RandomNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int maxInt = int.Parse(Console.ReadLine());
        if (min <= maxInt)
        {
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", random.Next(min, maxInt + 1));
            }
        }
        else
        {
            Console.WriteLine("Try again");
        }    
    }
}


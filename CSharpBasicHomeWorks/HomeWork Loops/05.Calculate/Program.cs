using System;


    class Calculate
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            float sum = 1;
            float factorial = 1;
            int power = x;
            for (int count = 1; count <= n; count++)
            {
                factorial *= count;
                sum += factorial / x;
                Console.WriteLine(sum);
                x *= power;
            }
            Console.WriteLine("{0 :F5}", sum);
        }
    }


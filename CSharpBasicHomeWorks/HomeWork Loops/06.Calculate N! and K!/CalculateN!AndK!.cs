using System;


class CalculateNK
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        if (1 < k && k < n && n < 100)
        {
            ulong resuult = 1;
            for (int i = k + 1; i <= n; i++)
            {
                resuult *= (ulong)i;
            }
            Console.WriteLine(resuult);
        }
        else
        {
            Console.WriteLine("out of range");
        }
    }
}

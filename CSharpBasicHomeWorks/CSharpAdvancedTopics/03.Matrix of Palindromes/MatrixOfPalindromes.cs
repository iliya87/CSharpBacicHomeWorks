using System;

class MatrixOfPalindromes
{
    static void Main(string[] args)
    {
        int r = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        char k = 'a';
        for (int i = 0; i < r; i++)        

        {
            for (int j = 0; j < c; j++)
            {
                char kd = Convert.ToChar(k + j);
                Console.Write("{0}{1}{0} ", k, kd);
            }

            Console.WriteLine();
            k++;
        }
    }
}


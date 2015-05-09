using System;

class Program
{

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
           int k  = int.Parse(Console.ReadLine());
            array[i] = k;
        }
        Array.Sort(array);
        foreach (var numbers in array )
        {

            Console.WriteLine(numbers);
        }
       
    }
}


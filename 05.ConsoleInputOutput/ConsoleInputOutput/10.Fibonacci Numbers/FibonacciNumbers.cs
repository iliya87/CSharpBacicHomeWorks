using System;


    class FibonacciNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the last member:");

        int counter = int.Parse(Console.ReadLine());
        decimal n = 0;
        decimal a = 1;
        decimal sum;

        for (int i = 0; i < counter; i++)
        {
            Console.Write("{0} ", n);
            sum = n + a;
            n = a;
            a = sum;
        }
    }
}

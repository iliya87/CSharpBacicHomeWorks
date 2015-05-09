using System;

    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a four digit integer : ");
            int n = int.Parse(Console.ReadLine());

            int d = n % 10;
            n = n / 10;
            int c = n % 10;
            n = n / 10;
            int b = n % 10;
            n = n / 10;
            int a = n % 10;

            int sum = a + b + c + d;

            Console.WriteLine("{0} sum of digits", sum);
            Console.WriteLine("{0}{1}{2}{3} reversed", d, c, b, a);
            Console.WriteLine("{0}{1}{2}{3} last digit in front", d, a, b, c);
            Console.WriteLine("{0}{1}{2}{3} second and third digits exchanged", a, c, b, d);
        }
    }

using System;

    class ThirdDigitIs7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an Integer");
            int n = int.Parse(Console.ReadLine());

            bool isSeven = (n / 100) % 10 == 7;

            Console.WriteLine("{0}", isSeven ? "The third digit is 7" :  "The third digit is Not 7");
        }
    }


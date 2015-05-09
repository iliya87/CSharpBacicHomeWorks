using System;

class CheckABitGivenPosition
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an Integer Number:");
        int i = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter bit's position:");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("The binary representation of the {0} is:\n{1}", i, Convert.ToString(i, 2).PadLeft(16, '0'));

        int bitChecker = 1;
        int check = ((i >> b) & bitChecker);

        Console.WriteLine("The bit on position {0} has value of: {1}" , b, ((check & bitChecker) != 0 ? "1 true" : "0 false"));   
    }
}


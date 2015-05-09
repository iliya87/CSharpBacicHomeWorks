using System;

class  BitwiseExtractBit
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an Integer number");
        int numb = int.Parse(Console.ReadLine());

        Console.WriteLine("The binary representation of the {0} is:\n{1}" , numb, Convert.ToString(numb, 2).PadLeft(16, '0'));
        int position = 3;
        int bitChecker = 1 << position;

        Console.WriteLine((numb & bitChecker) == bitChecker ? "The third bit is: 1 " : "The third bit is: 0");
    }
}

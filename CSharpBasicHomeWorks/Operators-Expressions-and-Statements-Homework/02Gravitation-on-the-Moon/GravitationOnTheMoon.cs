using System;


class GravitationOnTheMoon
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter some weight ");
        double n = double.Parse(Console.ReadLine());

        double weight = n * 17 / 100;
        Console.WriteLine("The weight ont the Moon is {0}", weight);
    }
}


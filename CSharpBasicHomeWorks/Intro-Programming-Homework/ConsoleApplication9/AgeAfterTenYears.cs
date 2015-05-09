using System;

class AgeAfterTenYears
{
    static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        int Age = int.Parse(Console.ReadLine());

        DateTime age = new DateTime(Age, 1, 1);
        Console.WriteLine("Your age after 10 years is: {0}", age.AddYears(10).Year);
        Console.ReadLine();

    }

}
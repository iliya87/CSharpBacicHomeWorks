using System;


class BooleanVariable
{


    static void Main()
    {
        bool isFemale;
        Console.WriteLine("What is your gender (type \"male\" or \"female\"): ");
        string myGender = Console.ReadLine();

        if (myGender == "female")
        {
            isFemale = true;
        }
        else
        {
            isFemale = false;
        }
        Console.WriteLine("Are you female: " + isFemale);
    }
}

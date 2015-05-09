using System;


class QuotesInStrings
{
    static void Main(string[] args)
    {
        string string1 = @"The ""use"" of quotations causes difficulties";
        string string2 = "The \"use\" of quotations causes difficulties";
           
        Console.WriteLine("{0}\n{1}", string1, string2);

    }
}


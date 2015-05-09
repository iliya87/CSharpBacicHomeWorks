using System;


namespace Strings_and_Objects
{
    class StringsAndObjects
    {
        
        static void Main(string[] args)
        {

            string firststring = "Hello";
            string secondstring = "World";
            object concatenation = firststring + " " + secondstring;

            string result = (string)concatenation;

            Console.WriteLine(result);

        }
    }
}

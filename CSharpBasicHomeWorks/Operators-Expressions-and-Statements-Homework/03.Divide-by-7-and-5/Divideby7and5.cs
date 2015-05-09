using System;

    class Divideby7and5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some integer : ");
            int numb = int.Parse(Console.ReadLine());

            bool n = (numb % 35 == 0) && (numb != 0);

            Console.WriteLine("The number is {0}", n ? "divisible by 5 and 7 in the same time" :
            "not  divisible by 5 and 7 in the same time");
        }
    }


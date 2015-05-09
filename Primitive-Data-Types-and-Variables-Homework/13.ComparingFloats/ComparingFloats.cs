using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class ComparingFloats
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers :");
            double numDouble1 = double.Parse(Console.ReadLine());
            double numDouble2 = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            bool checkNum = Math.Abs(numDouble1 - numDouble2) < eps;
            if (Math.Abs(numDouble1 - numDouble2) < eps)
            {
                Console.WriteLine(checkNum);
            }
            else if (Math.Abs(numDouble1 - numDouble2) >= eps)
            {
                Console.WriteLine(checkNum);
            }

        }
    }


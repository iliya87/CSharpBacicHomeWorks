using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

class RemoveNames
{
    static void Main(string[] args)
    {
        string mainList = Console.ReadLine();
        string replaceList = Console.ReadLine();

        List<string> firstList = new List<string>(mainList.Split());

        List<string> secondList = new List<string>(replaceList.Split());
        foreach (var item in secondList)
        {
            for (int i = 0; i < firstList.Count; i++)
            {
                if (item == firstList[i])
                {
                    firstList.RemoveAt(i); i--;
                }
            }
        }
        foreach (var item in firstList)
        {
            Console.WriteLine(item + " ");
        }
        Console.WriteLine();
    }
}


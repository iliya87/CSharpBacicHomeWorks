using System;

class RandomizeTheNumbersOneToN
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int[] array = new int[num];
        for (int i = 0; i < num; i++)
        {
            array[i] = i + 1;
        }

        Random random = new Random();
        foreach (int index in array)
        {
            int randNum = random.Next(0, num);
            int temp = array[randNum];
            array[randNum] = array[0];
            array[0] = temp;
        }
        Console.WriteLine(String.Join(" ", array));
    }
}


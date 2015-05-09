using System;


class PointInAndOutOfRectangle
{
    static void Main(string[] args)
    {
            double raduis = 1.5;
 
        Console.WriteLine("Enter X coordinate");
        double x = double.Parse(Console.ReadLine());
 
        Console.WriteLine("Enter Y coordinate");
        double y = double.Parse(Console.ReadLine());
 
        bool isInCircle = (Math.Sqrt(((x - 1) * (x - 1)) + ((y - 1) * (y - 1))) <= raduis);
        bool isOutRectangle = (-1 < x) ^ (x > 5) ^ (-1 < y) ^ (y > 1);
 
 
 
        if (isInCircle && isOutRectangle)
        {
            Console.WriteLine("The Point is within the circle and out of the rectangle");
        }
        else if (isInCircle && !isOutRectangle)
        {
            Console.WriteLine("The Point is within the circle and NOT out of the rectangle");
        }
        else if (!isInCircle && isOutRectangle)
        {
            Console.WriteLine("The Point is NOT within the circle and out of the rectangle");
        }
        else if (!isInCircle && !isOutRectangle)
        {
            Console.WriteLine("The Point is NOT within the circle and NOT out of the rectangle");
        }
      
    }
}


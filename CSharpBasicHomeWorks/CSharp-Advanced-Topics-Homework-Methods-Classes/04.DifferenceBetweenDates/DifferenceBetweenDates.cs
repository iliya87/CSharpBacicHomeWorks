using System;
using System.Globalization;
class DifferenceBetweenDates
{
    static void Main(string[] args)
    {
        string firstdate = Console.ReadLine();
        string seconddate = Console.ReadLine();
        string format = "d.MM.yyyy";

        DateTime date1 = DateTime.ParseExact(firstdate, format, CultureInfo.InvariantCulture);

        DateTime date2 = DateTime.ParseExact(seconddate, format, CultureInfo.InvariantCulture);

        int difference = CalculateDifferenceBetweenDates(date1, date2);
        Console.WriteLine("Days Between dates are {0} :", difference);
    }
   public static int CalculateDifferenceBetweenDates(DateTime date1 ,DateTime date2)
    {
        TimeSpan ts = date2 - date2;
        int differenceDays = ts.Days;
        return differenceDays;
    }
}


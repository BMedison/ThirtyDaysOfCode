using System;

class Program
{
    static void Main(string[] args)
    {
        var returnDate = "23 12 1234";
        var expectedDate = "19 9 2468";

        string[] dataFormats = { "d M y", "d M yy", "d M yyy", "d M yyyy" };
        DateTime returnD = DateTime.ParseExact(returnDate, dataFormats, null, System.Globalization.DateTimeStyles.None);
        DateTime expectedD = DateTime.ParseExact(expectedDate, dataFormats, null, System.Globalization.DateTimeStyles.None);

        if(returnD.Year - expectedD.Year > 0)
        {
            Console.WriteLine("10000");
        }else if (returnD.Year - expectedD.Year < 0)
        {
            Console.WriteLine("0");
        }

        if (returnD.Month - expectedD.Month > 0)
        {
            Console.WriteLine($"{500 * (returnD.Month - expectedD.Month)}");
        }
        else if (returnD.Month - expectedD.Month < 0)
        {
            Console.WriteLine("0");
        }

        if(returnD.Day - expectedD.Day > 0)
        {
            Console.WriteLine($"{15 * (returnD.Day - expectedD.Day)}");
        }else if (returnD.Day - expectedD.Day < 0)
        {
            Console.WriteLine("0");
        }

        Console.WriteLine(0);
        Console.ReadLine();
    }
}

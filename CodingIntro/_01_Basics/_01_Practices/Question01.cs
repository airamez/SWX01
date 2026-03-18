using System;

// 01. Read a value in miles and convert to kilometers: 1 Mile = 1.60934KM.
public class Questions01
{
    public static void Run()
    {
        Console.Write("Distance in Miles: ");
        decimal miles = decimal.Parse(Console.ReadLine());
        decimal kilometers = miles * 1.60934m;
        Console.WriteLine($"{miles} miles is {kilometers:F3} kilometers");
    }
}
using System;

public class Questions02
{
    public static void Run()
    {
        //02. Read an integer number and print the three predecessors and successors.

        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine() ?? "0");
        int pred1 = number - 3;
        int pred2 = number - 2;
        int pred3 = number - 1;
        int succ1 = number + 1;
        int succ2 = number + 2;
        int succ3 = number + 3;
        Console.WriteLine($"{pred1}, {pred2}, {pred3}");
        Console.WriteLine($"{succ1}, {succ2}, {succ3}");
    }
}
public class MathOperations
{
    public static void Run ()
    {
        // Integer division
        int a = 7;
        int b = 3;
        int result = a / b;
        int module = a % b;
        Console.WriteLine($"{a} / {b} = {result}");
        Console.WriteLine($"{a} % {b} = {module}");

        result = b / a;
        module = b % a;
        Console.WriteLine($"{b} / {a} = {result}");
        Console.WriteLine($"{b} % {a} = {module}");

        Console.WriteLine($"PI = {Math.PI}");
        Console.WriteLine($"Math.Abs(10)  = {Math.Abs(10)}");
        Console.WriteLine($"Math.Abs(-10) = {Math.Abs(-10)}");

        int number1 = 15;
        int number2 = 7;
        int number3 = 3;
        Console.WriteLine($"Math.Max({number1}, {number2}) = {Math.Max(number1, number2)}");
        Console.WriteLine($"Math.Min({number1}, {number2}) = {Math.Min(number1, number2)}");
        Console.WriteLine($"Max = {Math.Max(Math.Max(number1, number2), number3)}");
        Console.WriteLine($"Min = {Math.Min(Math.Min(number1, number2), number3)}");

        Console.WriteLine($"2^4 = {Math.Pow(2, 4)}");
        Console.WriteLine($"{number2}^{number3} = {Math.Pow(number2, number3)}");

        Console.WriteLine($"Square Root of 81 = {Math.Sqrt(81)}");
        Console.WriteLine($"Square Root of 121 = {Math.Sqrt(121)}");
        Console.WriteLine($"Square Root of 541 = {Math.Sqrt(541)}");

        double value = 3.477434;
        Console.WriteLine($"Ceiling  : {Math.Ceiling(value)}");
        Console.WriteLine($"Floor    : {Math.Floor(value)}");
        Console.WriteLine($"Round    : {Math.Round(value, 2)}");
        Console.WriteLine($"Truncate : {Math.Truncate(value)}");

        // Random  Numbers
            Random random = new Random();
        int rndNumber1 = random.Next(); // Greater or equals to 0 and smaller than Int32.MaxValue
        int rndNumber2 = random.Next(10); // Greater or equals to 0 and smaller than 10
        int rndNumber3 = random.Next(10, 15); //Greater or equals to 10 and smaller than 15

        Console.WriteLine(rndNumber1);
        Console.WriteLine(rndNumber2);
        Console.WriteLine(rndNumber3);
    }
}
using System;

/*
Definition of VARIABLE:
 - A variable in coding is a named storage location in a program’s memory that holds a value, which can change during program execution.
   It acts like a container for data — such as numbers, text, or more complex structures 
   Allowing programmers to store, retrieve, and manipulate information dynamically .
 - In most programming languages, variables have:
   - A name (identifier) to reference them.
   - A data type (explicit in statically typed languages like C++/Java, implicit in dynamically typed languages like Python/JavaScript).
  A value that can be updated during execution.

Types
 Built-in or Primitive Types:
 - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types
 - Most common ones:
   - int
   - decimal
     - For money use decimal. Prevents Rounding Errors from float and double
   - bool

 String:
 - https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/
 - It is a class (Reference type)
 - It is immutable
 - Most used type

 String Interpolation:
 - Prefix a string literal with $ to create an interpolated string.
 - Embed variables or any C# expression inside { } — evaluated at runtime.
 - Syntax: $"text {expression} text"
 - Supports format specifiers: {value:F2}, {value:C}, {value:N0}
 - Supports alignment/padding:  {value,10} (right) or {value,-10} (left)
 - Combine both:                 {value,-10:F2}
 - Use $@"..." (verbatim interpolated) to avoid escaping backslashes.

 Variable Declaration
   TYPE NAME

 Assignment
   NAME = VALUE or EXPRESSION

 */

public class VariablesDemo
{
    public static void Run()
    {
        // =============================================
        // 1. DECLARATION AND ASSIGNMENT
        // =============================================
        // Declaration:  TYPE NAME
        // Assignment:   NAME = VALUE or EXPRESSION
        // Both at once: TYPE NAME = VALUE

        int age;           // declaration only
        age = 25;          // assignment

        int year = 2026;   // declaration + assignment in one line
        bool isStudent = true;
        decimal price = 19.99m;  // the 'm' suffix tells the compiler this is a decimal literal (not double)
        string firstName = "Ada";

        Console.WriteLine("=== Declaration & Assignment ===");
        Console.WriteLine($"age      : {age}");
        Console.WriteLine($"year     : {year}");
        Console.WriteLine($"isStudent: {isStudent}");
        Console.WriteLine($"price    : {price}");
        Console.WriteLine($"firstName: {firstName}");

        // Re-assigning a variable
        age = 30;
        Console.WriteLine($"age after reassignment: {age}");


        // =============================================
        // 2. CONVERSION
        // =============================================
        // Implicit conversion: no data loss — compiler does it automatically
        int intValue = 10;
        decimal fromInt = intValue;      // int → decimal (safe, no cast needed)
        Console.WriteLine();
        Console.WriteLine("=== Conversion ===");
        Console.WriteLine($"Implicit int → decimal: {fromInt}");

        // Explicit conversion (cast): possible data loss — you must be explicit
        decimal decimalValue = 9.99m;
        int truncated = (int)decimalValue;  // decimal → int: fractional part is lost
        Console.WriteLine($"Explicit decimal → int (cast): {truncated}  (was {decimalValue})");

        // Convert class: safe string → number conversions
        string numberText = "42";
        int parsed = Convert.ToInt32(numberText);
        Console.WriteLine($"Convert.ToInt32(\"{numberText}\") = {parsed}");

        // int.Parse: string → int (throws exception if invalid)
        int parsed2 = int.Parse("100");
        Console.WriteLine($"int.Parse(\"100\") = {parsed2}");

        // int.TryParse: safe parsing — returns false instead of throwing
        bool success = int.TryParse("abc", out int result);
        Console.WriteLine($"int.TryParse(\"abc\") success: {success}, result: {result}");

        // ToString: any type → string
        string ageText = age.ToString();
        Console.WriteLine($"age.ToString() = \"{ageText}\"");


        // =============================================
        // 3. INPUT & OUTPUT
        // =============================================
        // Output: Console.Write (no newline) / Console.WriteLine (with newline)
        // Input:  Console.ReadLine() — always returns a string
        Console.WriteLine();
        Console.WriteLine("=== Input & Output ===");

        Console.Write("Type your name: ");
        string name = Console.ReadLine() ?? "";
        Console.WriteLine($"Hello, {name}!");

        Console.Write("Type a whole number: ");
        int number1 = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Type another whole number: ");
        int number2 = int.Parse(Console.ReadLine() ?? "0");

        int sum        = number1 + number2;
        int difference = number1 - number2;
        int product    = number1 * number2;
        int intDivide  = number1 / number2;           // truncates
        decimal decDivide = (decimal)number1 / number2; // exact

        Console.WriteLine($"Sum        : {number1} + {number2} = {sum}");
        Console.WriteLine($"Difference : {number1} - {number2} = {difference}");
        Console.WriteLine($"Product    : {number1} * {number2} = {product}");
        Console.WriteLine($"Int divide : {number1} / {number2} = {intDivide}");
        Console.WriteLine($"Dec divide : {number1} / {number2} = {decDivide}");
    }
}
using System;

class ArithmaticOperators
{
    static void Main()
    {
        int sum = 5 + 3;
        int difference = 5 - 3;
        int product = 5 * 3;
        double division = 10 / 3;
        double modulus = 10 % 3;

        Console.WriteLine($"Sum is {sum}");
        Console.WriteLine($"difference is {difference}");
        Console.WriteLine($"product is {product}");
        Console.WriteLine($"division is {division}");
        Console.WriteLine($"modulus is {modulus}");

        //combine two strings by using concat
        string result = String.Concat("Hello", "World");
        Console.WriteLine($"Combined string is {result}");
    }
}




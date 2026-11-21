using System;

internal class LogicalOperators
{
    static void Main()
    {
        bool checkValue1 = true && true; // true
        Console.WriteLine($"checkValue1 is {checkValue1}");

        bool checkValue2 = true && false; // true
        Console.WriteLine($"checkValue is {checkValue2}");

        bool checkValue3 = false && true; // true
        Console.WriteLine($"checkValue is {checkValue3}");

        bool checkValue4 = false && false; // true
        Console.WriteLine($"checkValue is {checkValue4}");

        //OR operator
        Console.WriteLine("OR operator");

        bool checkValue5 = true || true;
        Console.WriteLine($"checkValue is {checkValue5}");

        bool checkValue6 = true || false;
        Console.WriteLine($"checkValue is {checkValue6}");

        bool checkValue7 = false || true;
        Console.WriteLine($"checkValue is {checkValue7}");

        bool checkValue8 = false || false;
        Console.WriteLine($"checkValue is {checkValue8}");


        Console.WriteLine("NOT operator");

        bool checkValue9 = !true;
        Console.WriteLine($"checkValue is {checkValue9}");

        bool checkValue10 = !false;
        Console.WriteLine($"checkValue is {checkValue10}");

        bool checkValue11 = !(5 == 5);
        Console.WriteLine(checkValue11);

        bool checkValue12 = !(5 == 6);
        Console.WriteLine(checkValue12);
    }
}




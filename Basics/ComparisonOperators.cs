using System;

class ComparisonOperators
{
    static void Main()
    {
        bool x = true;
        bool y = false;

        bool isEqual = 5 == 6;
        Console.WriteLine(isEqual);

        bool isNotEqual = 5 != 5;
        Console.WriteLine(isNotEqual);

        bool isGreater = 10 > 5;
        Console.WriteLine(isGreater);

        bool isLess = 3 < 7;
        Console.WriteLine(isLess);

        string userName = "Alice";
        int lenOfUserName = 5;

        bool isLengthEqual = userName.Length == lenOfUserName;
        Console.WriteLine(isLengthEqual);


    }
}




using System;

internal class Strings
{
    static void Main()
    {
        string str = "Hello World";
        string str1 = "\"Manu\"";
        Console.WriteLine(str);
        Console.WriteLine(str1);

        string numberStrings = "One.\nTwo.\nThree";
        Console.WriteLine(numberStrings);

        string path = "C:\\Users\\Manu\\Documents";
        Console.WriteLine(path);

        string path2 = @"C:\Users\Manu\Documents";
        Console.WriteLine(path2);

        string name = "Manu";
        
        int age = 30;

        string message = $"My name is {name} and I am {age} years old";
        Console.WriteLine(message);


        string multiLineString = @"This is a multi-line string.
        It can span multiple lines without the need for escape characters.
        You can also include special characters like \n and \t without them being interpreted as escape sequences.";
        Console.WriteLine(multiLineString);

        string sampleString = "This is a sample string";
        int lengthOfString = sampleString.Length;
        Console.WriteLine($"Lnegth of the string {lengthOfString}");

        string text = "Hello World";
        Console.WriteLine(text.ToUpper());

        string text2 = "Hello World";
        Console.WriteLine(text2.ToLower());

        string cName = "     Manu     ";
        Console.WriteLine(cName);
        Console.WriteLine(cName.Trim());

        string cNamewithStars = "*****Manu*****";
        Console.WriteLine($"Before trim: {cNamewithStars}");
        Console.WriteLine($"After trim: {cNamewithStars.Trim('*')}");

        string removeStarsBeforecName = cNamewithStars.TrimStart('*');
        Console.WriteLine($"after removing stars before text : {removeStarsBeforecName}");
        Console.WriteLine(cNamewithStars.TrimEnd('*'));

        string cName2 = "Manu";
        Console.WriteLine(cName2.PadLeft(10, '@'));
        Console.WriteLine(cName2.PadRight(10, '*'));
    }
}




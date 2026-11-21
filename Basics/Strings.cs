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

        //string comparison
        string value = "Hello 1234";
        bool isEqual = value.Equals("Hello world");
        Console.WriteLine(isEqual);

        string sentence = "The quick brown fox jump over the lazy dog";
        string substring = sentence.Substring(4);
        Console.WriteLine($"substring is: {substring}");

        string substring2 = sentence.Substring(0, 9);
        Console.WriteLine($"substring2 is: {substring2}");

        string replaceString = sentence.Replace("brown", "red");
        Console.WriteLine($"replaceString: {replaceString}");

        //string formating
        int quantity = 5;
        double price = 9.99;
        string formattedString = string.Format("The total cost is {0} for items purchased {1}", price, quantity);
        Console.WriteLine($"formattedString is : {formattedString}");


    }
}




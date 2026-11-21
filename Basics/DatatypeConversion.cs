using System;

class DatatypeConversion
{
    public static void Main()
    {
        //implicit type conversion
        byte num= 100;
        int convertednum = num;
        Console.WriteLine(convertednum);

        //explicit conversion
        int salary = 2000;
        byte convertedSalary = (byte)salary;
        Console.WriteLine($"converted salary : {convertedSalary}");

        double price = 99.856;
        int convertedPrice = (int)price;
        Console.WriteLine($"converted price: {convertedPrice}");

        int num1 = 250;
        byte convertednum1 = (byte)num1;
        Console.WriteLine(convertednum1);

        //int to string 
        int number = 100;
        string converteNumber = number.ToString();

        //string to int
        string age = "34";
        
        int convertedAge = int.Parse(age);
        Console.WriteLine($"converted age: {convertedAge}");

        //boxing and unboxing
        int age1 = 25;
        
        object obj = age1;
        
        Console.WriteLine(age1);
        Console.WriteLine(obj);

        int newAge = (int)obj;
        Console.WriteLine(newAge);
        



    }
}




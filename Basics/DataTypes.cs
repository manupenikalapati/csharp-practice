using System;

class Datatypes
{ 
    static void Main()
    {
        byte age = 25;
        Console.WriteLine(age);

        byte studentNum = 10;
        Console.WriteLine(studentNum);

        byte numOfBottles = 255;  //byte max value is 255, min value is 0
        Console.WriteLine(numOfBottles);

        short temperature = 20; //short max value is 32767, min value is -32768
        Console.WriteLine(temperature);

        ushort numOfStudents = 1000; //ushort max value is 65535, min value is 0
        Console.WriteLine(numOfStudents);

        int salary = 20000; //int max value is 2147483647, min value is -2147483648
        Console.WriteLine(salary);

        uint population = 3496332233; //uint max value is 4294967295, min value is 0
        Console.WriteLine(population);

        long distance = 10000000000; //long max value is 9223372036854775807, min value is -9223372036854775808
        Console.WriteLine(distance);

        ulong numOfStars = 10000000000000000000; //ulong max value is 18446744073709551615, min value is 0
        Console.WriteLine(numOfStars);

        decimal price = 19.99m;
        Console.WriteLine(price);

        float pi = 3.14f;
        Console.WriteLine(pi);

        double e = 2.718281828459045;
        Console.WriteLine(e);


        Console.WriteLine($"Min Value of byte: {byte.MinValue}, Max Value of byte: {byte.MaxValue}");
        Console.WriteLine($"Min Value of short: {short.MinValue}, Max Value of short: {short.MaxValue}");
        Console.WriteLine($"Min Value of ushort: {ushort.MinValue}, Max Value of ushort: {ushort.MaxValue}");
        Console.WriteLine($"Min Value of int: {int.MinValue}, Max Value of int: {int.MaxValue}");
        Console.WriteLine($"Min Value of uint: {uint.MinValue}, Max Value of uint: {uint.MaxValue}");
        Console.WriteLine($"Min Value of long: {long.MinValue}, Max Value of long: {long.MaxValue}");
        Console.WriteLine($"Min Value of ulong: {ulong.MinValue}, Max Value of ulong: {ulong.MaxValue}");


        Boolean isCsharpFun = true;
        Console.WriteLine(isCsharpFun);

        Boolean isFishTasty = false;
        Console.WriteLine(isFishTasty);

        char grade = 'A';
        Console.WriteLine(grade);

        string name = "Manmohan";
        Console.WriteLine(name);

    }
}
using System;

class VarAndDynamic
{
    static void Main()
    {
        var age = 33;
    
        Console.WriteLine("Age : " + age);
        Console.WriteLine("Type of age: " + age.GetType());

        dynamic studentNum = 10;
        studentNum = "Manu";  //we can assign string value to studentNum because it is dynamic type
        Console.WriteLine("Student Number : " + studentNum);
        Console.WriteLine("Type of studentNum: " + studentNum.GetType());
    }
}


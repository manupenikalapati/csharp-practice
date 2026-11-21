using System;

class If_Else_Statement
{
    static void Main()
    {
        if(10 > 5)
        {
            Console.WriteLine("10 is greater than 5");
        }

        int Age = 30;
        if(Age > 5)
        {
            Console.WriteLine("You are eligible to vote");
        }

        string name = "";
        if(name == "John")
        {
            Console.WriteLine("Hello John");
        }else
        {
            Console.WriteLine("Employee not found");
        }

        string name1 = "Ram";
        if(name1 == "John")
        {
            Console.WriteLine("Hello John");
        }else if(name1 == "Ram")
        {
            Console.WriteLine("Hello Ram");
        }else
        {
            Console.WriteLine("Employee Not Found");
        }

    }
}




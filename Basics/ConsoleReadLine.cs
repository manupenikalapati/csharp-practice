using System;

class ConsoleReadLine
{
    static void Main()
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        

        Console.WriteLine("Enter your password:");
        string password = Console.ReadLine();
        

        Console.WriteLine("Enter your empId:");
        int empId = int.Parse(Console.ReadLine());

        Console.WriteLine($"Your name is: {name}");
        Console.WriteLine($"Your password is: {password}");
        Console.WriteLine($"Your empId is: {empId}");

        string result = String.Format("Name is: {0}, Password is: {1}, EmpId is: {2}", name, password, empId);
        Console.WriteLine(result);

    }
}




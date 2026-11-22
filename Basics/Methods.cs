using System;

class Methods
{
    static void Main()
    {
        //Method1();
        //Method2();
        //CallMethod1();
        //CallMethod2();
        //Console.WriteLine(NameMethod());
        //string empName = NameMethod();
        //Console.WriteLine(empName);
        //int empId = EmpId();
        //Console.WriteLine(empId);

        //int number = MethodWithParams(10);
        //Console.WriteLine(number);

        //string detailsOfEmp = getEmpDetails(101);
        //Console.WriteLine(detailsOfEmp);

        string[] names = getEmpNames();
        
        foreach(string name in names)
        {
            Console.WriteLine(name);
        }


    }

    static void Method1()
    {
        Console.WriteLine("Method one is called");
    }

    static void Method2()
    {
        Console.WriteLine("Mothod two is called");
    }

    static void CallMethod1()
    {
        Method1();
        
    }

    static void CallMethod2()
    {
        Method2();
        
    }


    //Methods with return types

    static string NameMethod()
    {
        string empName = "Manu";
        return empName;
    }

    //Method return int type

    static int EmpId()
    {
        int empId = 105;
        return empId;
    }

    //method with params

    static int MethodWithParams(int number)
    {
        return number;
    }

    static string getEmpDetails(int idNum)
    {
        string empDetails = $"Employee name is Manu and his id is {idNum}";
        return empDetails;
    }

    static string[] getEmpNames()
    {
        string[] empNames = ["Manu", "Navin", "Dhanu"];
        return empNames;
    }


}




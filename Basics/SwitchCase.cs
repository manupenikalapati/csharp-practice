using System;

class SwitchCase
{
    static void Main()
    {
        int day = 3;
        switch (day)
        {
            case 1:
                Console.WriteLine("It is Monday");
                break;
            case 2:
                Console.WriteLine("It is Tuesday");
                break;
            default:
                Console.WriteLine("No day found");
                break;
        }
    }
}




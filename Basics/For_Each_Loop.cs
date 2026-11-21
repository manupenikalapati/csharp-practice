using System;

class For_Each_Loop
{
    static void Main()
    {
        int[] numbers = [1, 2, 3, 4, 5];

        foreach(int num in numbers)
        {
            Console.WriteLine(num);
        }


        Console.WriteLine("For Loop");

        for(int currency = 0; currency < 5; currency = currency + 1)
        {
            Console.WriteLine($"Currency value : {currency}");
        }
    }
}




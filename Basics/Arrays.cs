using System;


internal class Arrays
{
    static void Main()
    {
        int[] numbersGroup = new int[2];
        numbersGroup[0] = 10;
        numbersGroup[1] = 20;

        Console.WriteLine($"result array: {numbersGroup}");

        int[] numbersGroup1 = new int[] { 10, 20 };
        Console.WriteLine(numbersGroup1[0]);
        Console.WriteLine(numbersGroup1[1]);

        int[] numbersGroup3 = new int[] { 10, 20, 30, 40, 50 };

        int[] numbergroup4 = { 10, 20, 30, 40, 50 };


        //loops using foreach
        int[] currencyNotes = { 10, 50, 100, 500 };

        foreach(int note in currencyNotes)
        {
            Console.WriteLine($"currency notes: {note}");
        }

        foreach (int note in currencyNotes)
        {
            int newCoin = 5;
            int updatedCurrencyNote = newCoin + note;
            Console.WriteLine($"updated currency notes: {updatedCurrencyNote}");

        }

        //length of array
        string[] books = { "Telugu", "Hindi", "Sanskrit" };
        int booksLength = books.Length;
        Console.WriteLine(booksLength);

        books[1] = "English";
        Console.WriteLine(books);
    }
}



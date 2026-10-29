using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> Numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");
        string userEntry = Console.ReadLine();
        int numberEntry = int.Parse(userEntry);
        if (numberEntry != 0)
            Numbers.Add(numberEntry);
        while (numberEntry != 0)
        {
            Console.Write("Enter number: ");
            userEntry = Console.ReadLine();
            numberEntry = int.Parse(userEntry); 
            if (numberEntry != 0)
                Numbers.Add(numberEntry);
        }

        int sum = Numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");
        double avg = Numbers.Average();
        Console.WriteLine($"The average is: {avg}");
        var max = Numbers.Max();
        Console.WriteLine($"The largest number is: {max}");
    }
}
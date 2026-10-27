using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your score? ");
        string userGrade = Console.ReadLine();
        int userGradeNumeric = int.Parse(userGrade);


        if (userGradeNumeric >= 90)
        {
            string letter = "A";
            Console.WriteLine($"Your grade is {letter}.");
        }

        else if (userGradeNumeric >= 80)
        {
            string letter = "B";
            Console.WriteLine($"Your grade is {letter}.");
        }

        else if (userGradeNumeric >= 70)
        {
            string letter = "C";
            Console.WriteLine($"Your grade is {letter}.");
        }

        else if (userGradeNumeric >= 60)
        {
            string letter = "D";
            Console.WriteLine($"Your grade is {letter}.");
        }

        else if (userGradeNumeric < 60)
        {
            string letter = "F";
            Console.WriteLine($"Your grade is {letter}.");
        }


        if (userGradeNumeric >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Study hard and try again next time!");
        }
    }
}
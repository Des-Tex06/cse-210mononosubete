using System;

class Program
{
    static void Main(string[] args)
    {   
        //Random randomGenerator = new Random();
        //int magicNumber = randomGenerator.Next(1, 11);

        int magicNumber = 8;
        Console.Write("What is the magic number? ");
        string guess = Console.ReadLine();
        int userGuess = int.Parse(guess);
        
        while (!(userGuess == magicNumber))
        {
            Console.Write("What is the magic number? ");
            string guessAgain = Console.ReadLine();
            int numberGuess = int.Parse(guessAgain);
            
            if (numberGuess < magicNumber)
            {
                Console.WriteLine("Geuss higher");

            }

            else if (numberGuess > magicNumber)
            {
                Console.WriteLine("Guess lower");
            }
        }

        Console.WriteLine("You guessed the Magic Number!");



    }
        
}

using System;

class Program
{
    static void Main(string[] args)
    {   
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        //int magicNumber = 8;
        Console.Write("What is the magic number? ");
        string guess = Console.ReadLine();
        int userGuess = int.Parse(guess);

        if (userGuess < magicNumber)
        {
            Console.WriteLine("Geuss higher");
        }
        else if (userGuess > magicNumber)
        {
            Console.WriteLine("Guess lower");
        }
        
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

            else if (numberGuess == magicNumber)
            {
                break; //This helped break my loop.
            }
        }

        Console.WriteLine("You guessed the Magic Number!");



    }
        
}

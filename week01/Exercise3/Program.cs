using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int userGuess = -1;
        string userInput = "";

        while (userGuess != magicNumber)
        {
            Console.WriteLine("What is your guess");
            userInput = Console.ReadLine();
            userGuess = int.Parse(userInput);

            if (magicNumber > userGuess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < userGuess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
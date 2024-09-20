using System;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Game loop
            bool playAgain = true;
            while (playAgain)
            {
                // Initialize variables
                Random random = new Random();
                int magicNumber = random.Next(1, 101);
                int guess;
                int numberOfGuesses = 0;

                // Game loop
                while (true)
                {
                    // Ask user for their guess
                    Console.Write("What is your guess? ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    numberOfGuesses++;

                    // Check if guess is correct
                    if (guess == magicNumber)
                    {
                        Console.WriteLine("You guessed it!");
                        Console.WriteLine($"It took you {numberOfGuesses} guesses.");
                        break;
                    }
                    else if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else
                    {
                        Console.WriteLine("Lower");
                    }
                }

                // Ask user if they want to play again
                Console.Write("Do you want to play again? (yes/no): ");
                string response = Console.ReadLine().ToLower();
                playAgain = response == "yes";
            }
        }
    }
}
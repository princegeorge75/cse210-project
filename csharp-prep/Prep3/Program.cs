using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        string playAgain = "yes";

        // Loop to restart the game if the user wants to play again
        while (playAgain.ToLower() == "yes")
        {
            // Generate a random magic number between 1 and 100
            Random random = new Random();
            int magicNumber = random.Next(1, 101);  // 101 because it's exclusive

            int guess = -1;  // Initialize with a value that won't match the magic number
            int numberOfGuesses = 0;  // Counter for number of guesses

            // Loop until the user guesses the correct number
            while (guess != magicNumber)
            {
                // Ask the user to input their guess
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                // Increment the number of guesses
                numberOfGuesses++;

                // Check if the guess is higher, lower, or correct
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! It took you {numberOfGuesses} guesses.");
                }
            }

            // Ask if they want to play again
            Console.Write("Do you want to play again (yes/no)? ");
            playAgain = Console.ReadLine();
        }

        // Final message when the user exits the game
        Console.WriteLine("Thank you for playing!");
    }
}
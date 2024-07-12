using System;

public class NumberGuessingGame
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;

        while (playAgain)
        {
            int noOfAttempts = 0;
            int randomNum = random.Next(1, 11);
            int userGuess = 0;

            while (noOfAttempts < 3)
            {
                bool validInput = false;

                while (!validInput)
                {
                    Console.WriteLine("Enter a number between 1 and 10:");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out userGuess) && userGuess >= 1 && userGuess <= 10)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 10.");
                    }
                }

                if (randomNum > userGuess)
                {
                    Console.WriteLine("Sorry, too low.");
                }
                else if (randomNum < userGuess)
                {
                    Console.WriteLine("Sorry, too high.");
                }
                else
                {
                    if (noOfAttempts == 0)
                    {
                        Console.WriteLine("Congratulations! You won, you guessed it in 1 attempt.");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations! You won, you guessed it in {noOfAttempts + 1} attempts.");
                    }
                    break; // Exit the attempts loop if guessed correctly
                }

                noOfAttempts++;
            }

            if (noOfAttempts == 3)
            {
                Console.WriteLine($"You've used all your attempts. The correct number was {randomNum}.");
            }

            Console.WriteLine("Press 1 to play again or 0 to exit:");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || (choice != 0 && choice != 1))
            {
                Console.WriteLine("Invalid choice. Press 1 to play again or 0 to exit:");
            }

            if (choice == 0)
            {
                playAgain = false;
            }
        }

        Console.WriteLine("Thank you for playing!");
    }
}

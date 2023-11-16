namespace GuessTheNumber
{
    class Program
    {
        static void Main()
        {
            bool isGameOver = false;

            while (!isGameOver)
            {
                Random rnd = new Random();
                int numToGuess = rnd.Next(1, 101);
                int playerGuess = 0;

                Console.WriteLine("Guess a number between 1 and 100");

                while (playerGuess != numToGuess)
                {
                    Console.Write("Enter your guess: ");
                    playerGuess = Convert.ToInt32(Console.ReadLine());

                    if (playerGuess < numToGuess)
                    {
                        Console.WriteLine("The number is too low");
                    }
                    else if (playerGuess > numToGuess)
                    {
                        Console.WriteLine("The number is to high");
                    }
                }

                Console.WriteLine("You guessed the correct number!");
            }
        }
    }
}

namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            bool playAgain = true;

            int min = 1;
            int max = 100;
            int guess;

            int number;
            int guesses;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + "-" + max + ":");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess < number)
                    {
                        Console.WriteLine("Choose a bigger number.");
                        guesses++;
                    }
                    else if (guess > number)
                    {
                        Console.WriteLine("Choose a smaller number.");
                        guesses++;
                    }
                    else
                    {
                        Console.WriteLine("A WINNER IS YOU!!");
                        Console.WriteLine("It took you " + guesses + " attempts");
                    }
                }
                Console.WriteLine("Do you want to play again? (y/n)");
                char answer = Convert.ToChar(Console.ReadLine().ToLower());
                while (answer != 'y' && answer != 'n')
                {
                    Console.WriteLine("Please enter a valid answer (y/n)");
                    Console.WriteLine("Do you want to play again?");
                    answer = Convert.ToChar(Console.ReadLine().ToLower());
                };
                if (answer == 'y')
                {
                    guess = 0;
                    guesses = 0;
                    number = random.Next(min, max + 1);
                }
                else
                {
                    playAgain = false;
                    Console.WriteLine("Thanks for guessing");
                };
            }

            Console.ReadKey();
        }
    }
}

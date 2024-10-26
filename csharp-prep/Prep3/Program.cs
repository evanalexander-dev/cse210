using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        string play = "yes";
        while (play == "yes")
        {
            int randomNumber = randomGenerator.Next(1, 101);
            int guess;
            int guessCounter = 0;

            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCounter++;
                if (guess < randomNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCounter} guesses.");
                }
            } while (guess != randomNumber);

            Console.Write("Do you want to play again? (yes/no) ");
            play = Console.ReadLine();
        }
    }
}
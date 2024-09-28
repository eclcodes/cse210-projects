using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "Y";

        while (playAgain == "Y")
        {

            Random randomGenterator = new Random();
            int magicNumber = randomGenterator.Next(1, 101);

            int guess = 0;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed correct!");
                    Console.Write("Do you want to play again?(Y/N) ");
                    playAgain = Console.ReadLine();
                }
            }    
        }
    }
}
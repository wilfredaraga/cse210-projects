using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "";
        
        do
        {
            Boolean guessed = true;
            Console.WriteLine("What is the magic number?");
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);
            
            do
            {
                Console.Write("What is your guess? ");
                int guessNumber = int.Parse(Console.ReadLine());

                if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                    guessed = false;
                }
                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                    guessed = false;
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    guessed = true;
                    Console.Write("Do you want to play again? ");
                    playAgain = Console.ReadLine();   
                }
            } while (!guessed);
        } while (playAgain == "yes");
    }
}
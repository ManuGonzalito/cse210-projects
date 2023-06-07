using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");
        // Console.Write("What is the magic number? ");
        string play = "yes";

        while (play == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int guessNumber = 0;
            string userInput = "";
            int attemps = 0;


            while (magicNumber != guessNumber)
            {
                Console.Write("What is your guess? ");
                userInput = Console.ReadLine();
                guessNumber = int.Parse(userInput);

                if (magicNumber > guessNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guessNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!! ");
                }

                attemps ++;
            }
            Console.WriteLine("");
            Console.WriteLine($"You guessed in {attemps} attemps");

            Console.WriteLine("");
            Console.Write("Do you want to play again? ");
            play = Console.ReadLine();
        }
        Console.WriteLine("Goodbye!");
    }
}
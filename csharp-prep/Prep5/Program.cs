using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            string response = Console.ReadLine();
            int number = int.Parse(response);
            return number;
        }

        static int SquareNumber(int number)
        {
            int squareNumber = number * number;
            return squareNumber;
        }

        static void DisplayResults(string name, int squareNumber)
        {
            Console.WriteLine($"{name}, the square of your number is: {squareNumber}");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squareNumber = SquareNumber(number);
        DisplayResults(name, squareNumber);
    }
}
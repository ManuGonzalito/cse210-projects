using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);
        string letter = "";
        string sign = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else if (gradePercentage < 60)
        {
            letter = "F";
        }

        if (gradePercentage % 10 >= 7 && letter != "A" && letter != "F")
        {
            sign = "+";
        }
        else if (gradePercentage % 10 < 3 && letter != "F")
        {
            sign = "-";
        }

        Console.WriteLine("");
        Console.WriteLine($"Your letter grade is {letter}{sign}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You pass!!");
        }
        else
        {
            Console.WriteLine("Next time you will do it.");
        }
    }
}
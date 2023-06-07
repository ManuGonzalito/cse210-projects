using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        int numberInput = -1;
        int total = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        while (numberInput != 0)
        {
            Console.Write("Enter a number: ");
            string response = Console.ReadLine();
            numberInput = int.Parse(response);

            if (numberInput != 0)
            {
                numbers.Add(numberInput);
            }
        }

        foreach (int number in numbers)
        {
            total += number;
        }

        float average = ((float) total) / numbers.Count;
        int max = numbers.Max();
        int min = numbers[0];
        
        foreach (int number in numbers)
        {
            if (number > 0 && number < min)
            {
                min = number;
            }
        }

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {min}");
        Console.WriteLine("The sorted list is: ");

        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
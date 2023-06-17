using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine("Welcome to Digital Journal!");
        int inputMenu = 0;
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal myJournal = new Journal();

        while (inputMenu != 5)
        {
            Console.WriteLine();
            Console.WriteLine("Please, select an option: ");
            Console.WriteLine("1. Write a new Entry");
            Console.WriteLine("2. Display all the Entries");
            Console.WriteLine("3. Load a File");
            Console.WriteLine("4. Save a File");
            Console.WriteLine("5. Quit");
            Console.Write("What do you like to do? ");
            inputMenu = int.Parse(Console.ReadLine());

            if (inputMenu == 1)
            {
                Entry newEntry = new();
                DateTime currentTime = DateTime.Now;
                newEntry._date = currentTime.ToString("dd/MM/yyyy HH:mm");
                newEntry._promptText = promptGenerator.GetRandomPrompt();

                Console.WriteLine();
                Console.WriteLine(newEntry._promptText);
                Console.Write(">");
                newEntry._entryText = Console.ReadLine();

                myJournal.AddEntry(newEntry);
            }
            else if (inputMenu == 2)
            {
                myJournal.DisplayAll();
            }
            else if (inputMenu == 3)
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
            }
            else if (inputMenu == 4)
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }
        }

        Console.WriteLine();
        Console.WriteLine("Goodbye!");
    }
}
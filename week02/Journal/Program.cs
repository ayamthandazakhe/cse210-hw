
/*
 * Creativity and Exceeding Requirements:
 *
 * 1. I included eight different journal prompts instead
 *    of the required minimum of five.
 *
 * 2. I created three additional classes:
 *    Entry, Journal, and PromptGenerator.
 *
 * 3. I used a custom delimiter when saving journal
 *    entries to make the information easier to separate
 *    when loading the file.
 *
 * 4. I organized the program into separate classes,
 *    demonstrating abstraction and encapsulation.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\n===== JOURNAL PROGRAM =====");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Load journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    // Get a random prompt
                    string prompt = promptGenerator.GetRandomPrompt();

                    Console.WriteLine("\n" + prompt);
                    Console.Write("Your response: ");

                    string response = Console.ReadLine() ?? "";

                    // Get the current date
                    string date = DateTime.Now.ToShortDateString();

                    // Create a new journal entry
                    Entry newEntry = new Entry(date, prompt, response);

                    journal.AddEntry(newEntry);

                    Console.WriteLine("Entry added successfully!");
                    break;

                case "2":
                    // Display all journal entries
                    journal.DisplayAll();
                    break;

                case "3":
                    // Save journal to a file
                    Console.Write("Enter filename: ");
                    string saveFile = Console.ReadLine() ?? "";

                    journal.SaveToFile(saveFile);
                    break;

                case "4":
                    // Load journal from a file
                    Console.Write("Enter filename: ");
                    string loadFile = Console.ReadLine() ?? "";

                    journal.LoadFromFile(loadFile);
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Thank you for using Journal Program!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

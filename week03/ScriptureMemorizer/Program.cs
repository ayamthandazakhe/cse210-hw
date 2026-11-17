
using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = null;
        string scriptureText = "";
        bool scriptureSelected = false;

        // Creativity addition:
        // I added a scripture library containing scriptures
        // from both the Bible and the Book of Mormon.
        // Users can choose from six different scriptures.
        // This makes the program more interactive and useful.

        while (!scriptureSelected)
        {
            Console.Clear();

            Console.WriteLine("================================");
            Console.WriteLine("       SCRIPTURE MEMORIZER");
            Console.WriteLine("================================");
            Console.WriteLine();

            Console.WriteLine("Choose a scripture to memorize:");
            Console.WriteLine();

            Console.WriteLine("BIBLE");
            Console.WriteLine("1. Proverbs 3:5-6");
            Console.WriteLine("2. John 3:16");
            Console.WriteLine("3. Philippians 4:13");

            Console.WriteLine();

            Console.WriteLine("BOOK OF MORMON");
            Console.WriteLine("4. 1 Nephi 3:7");
            Console.WriteLine("5. Mosiah 2:17");
            Console.WriteLine("6. 2 Nephi 2:25");

            Console.WriteLine();
            Console.Write("Enter your choice (1-6) or type quit: ");

            string choice = Console.ReadLine();

            if (choice == null || choice.Trim().ToLower() == "quit")
            {
                return;
            }

            switch (choice.Trim())
            {
                case "1":
                    reference = new Reference("Proverbs", 3, 5, 6);

                    scriptureText =
                        "Trust in the LORD with all thine heart; " +
                        "and lean not unto thine own understanding. " +
                        "In all thy ways acknowledge him, " +
                        "and he shall direct thy paths.";
                    scriptureSelected = true;
                    break;

                case "2":
                    reference = new Reference("John", 3, 16);

                    scriptureText =
                        "For God so loved the world, that he gave " +
                        "his only begotten Son, that whosoever " +
                        "believeth in him should not perish, " +
                        "but have everlasting life.";
                    scriptureSelected = true;
                    break;

                case "3":
                    reference = new Reference("Philippians", 4, 13);

                    scriptureText =
                        "I can do all things through Christ " +
                        "which strengtheneth me.";
                    scriptureSelected = true;
                    break;

                case "4":
                    reference = new Reference("1 Nephi", 3, 7);

                    scriptureText =
                        "And it came to pass that I, Nephi, said " +
                        "unto my father: I will go and do the things " +
                        "which the Lord hath commanded, for I know " +
                        "that the Lord giveth no commandments unto " +
                        "the children of men, save he shall prepare " +
                        "a way for them that they may accomplish " +
                        "the thing which he commandeth them.";
                    scriptureSelected = true;
                    break;

                case "5":
                    reference = new Reference("Mosiah", 2, 17);

                    scriptureText =
                        "And behold, I tell you these things that " +
                        "ye may learn wisdom; that ye may learn that " +
                        "when ye are in the service of your fellow " +
                        "beings ye are only in the service of your God.";
                    scriptureSelected = true;
                    break;

                case "6":
                    reference = new Reference("2 Nephi", 2, 25);

                    scriptureText =
                        "Adam fell that men might be; and men are, " +
                        "that they might have joy.";
                    scriptureSelected = true;
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Invalid choice. Please select 1-6.");
                    Console.ReadLine();
                    break;
            }
        }

        // Create the scripture object
        Scripture scripture = new Scripture(reference, scriptureText);

        // Start the memorization exercise
        bool quit = false;

        while (!scripture.IsCompletelyHidden() && !quit)
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            Console.WriteLine("Press Enter to hide three random words.");
            Console.WriteLine("Type 'quit' to exit.");
            Console.Write("> ");

            string input = Console.ReadLine();

            if (input != null && input.Trim().ToLower() == "quit")
            {
                quit = true;
            }
            else if (string.IsNullOrEmpty(input))
            {
                scripture.HideRandomWords(3);
            }
            else
            {
                Console.WriteLine("Please press Enter or type quit.");
                Console.ReadLine();
            }
        }

        // Display the final scripture
        Console.Clear();

        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();

        if (scripture.IsCompletelyHidden())
        {
            Console.WriteLine("Congratulations!");
            Console.WriteLine("You have hidden all the words.");
        }
        else
        {
            Console.WriteLine("You have exited the memorization exercise.");
        }
    }
}

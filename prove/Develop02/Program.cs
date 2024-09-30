using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice;
        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal (CSV)");
            Console.WriteLine("4. Load journal (CSV)");
            Console.WriteLine("5. Quit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Write a new entry
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToShortDateString();
                    Entry entry = new Entry(prompt, response, date);
                    theJournal.AddEntry(entry);
                    break;

                case 2:
                    // Display journal
                    theJournal.DisplayEntries();
                    break;

                case 3:
                    // Save journal to CSV file
                    Console.Write("Enter the filename to save (e.g., journal.csv): ");
                    string saveFilename = Console.ReadLine();
                    theJournal.SaveJournalAsCSV(saveFilename);
                    break;

                case 4:
                    // Load journal from CSV file
                    Console.Write("Enter the filename to load (e.g., journal.csv): ");
                    string loadFilename = Console.ReadLine();
                    theJournal.LoadJournalFromCSV(loadFilename);
                    break;

                case 5:
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }

        } while (choice != 5);
    }
}

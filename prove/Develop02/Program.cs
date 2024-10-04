using System;

// Journal Program
public class Program
{
    static void Main()
    {
        // Initialize journal and prompt generator
        var journal = new Journal();
        var promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program!");

        // Main menu loop
        while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    // Write a new journal entry
                    WriteEntry(journal, promptGenerator);
                    break;
                case "2":
                    // Display all journal entries
                    journal.DisplayAll();
                    break;
                case "3":
                    // Load journal from file
                    LoadJournal(journal);
                    break;
                case "4":
                    // Save journal to file
                    SaveJournal(journal);
                    break;
                case "5":
                    // Quit program
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }
        }
    }

    // Write a new journal entry
    static void WriteEntry(Journal journal, PromptGenerator promptGenerator)
    {
        // Automatically generate date
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Enter response: ");
        string response = Console.ReadLine();
        journal.AddEntry(new Entry(date, prompt, response));
    }

    // Load journal from file
    static void LoadJournal(Journal journal)
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
    }

    // Save journal to file
    static void SaveJournal(Journal journal)
{
    Console.Write("Enter filename: ");
    string filename = Console.ReadLine();
    journal.SaveToFile(filename);
}
} 

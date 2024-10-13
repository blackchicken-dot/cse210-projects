using System;

public class ScriptureMemorizer
{
    private Scripture scripture;
    private Random random;

    public ScriptureMemorizer(Scripture scripture)
    {
        this.scripture = scripture;
        random = new Random();
    }

    public void Run()
    {
        Console.WriteLine("Memorize the following scripture:");
        Console.WriteLine(scripture.Reference);
        Console.WriteLine(scripture.GetTextWithHiddenWords());

        while (true)
        {
            Console.Write("Press Enter to continue or type 'quit' to finish: ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            // Hide random words
            foreach (var word in scripture.Words)
            {
                if (!word.IsHidden && random.NextDouble() < 0.2)
                {
                    word.Hide();
                }
            }

            Console.Clear(); // Clear console

            Console.WriteLine(scripture.Reference);
            Console.WriteLine(scripture.GetTextWithHiddenWords());

            // Check if all words are hidden
            if (scripture.Words.All(word => word.IsHidden))
            {
                Console.WriteLine("Congratulations! You've memorized the scripture!");
                break;
            }
        }
    }
}
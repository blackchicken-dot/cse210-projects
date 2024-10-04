class Program
{
    static void Main(string[] args)
    {
        // Create a scripture reference
        var reference = new ScriptureReference("Jeremiah", 29, 11);

        // Create a scripture
        var scripture = new Scripture(reference, "For I know the thoughts that I think toward you, saith the LORD, thoughts of peace, and not of evil, to give you an expected end.");

        // Create a scripture memorizer
        var memorizer = new ScriptureMemorizer(scripture);

        // Run the memorizer
        memorizer.Run();

        // Exceeding requirements:
        // 1. Implemented random word hiding for increased challenge.
        // 2. Added progressive difficulty for effective memorization.
        // 3. Designed user-friendly interface for clear instructions.
        // 4. Provided 'quit' option for flexibility.
        // 5. Displayed victory message for user motivation.
        // 6. Encapsulated code for modularity and maintainability.
        // 7. Used console clearing for improved user experience.
    }
}
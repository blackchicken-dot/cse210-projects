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
        // 1. Implemented console clearing for a cleaner user experience.
        //    (Console.Clear() method used in ScriptureMemorizer.Run())
        // 2. Added user input prompt to proceed with scripture recall.
        //    (Console.ReadLine() method used in ScriptureMemorizer.Run())
        // 3. Encapsulated data and behavior within classes (ScriptureWord, ScriptureReference, Scripture, ScriptureMemorizer)
        // 4. Used random word hiding for increased memorization challenge.
    }
}
// MathAssignment.cs
public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // Constructor to initialize all parameters including the base class attributes
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Method to get the list of homework problems
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}

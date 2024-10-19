// WritingAssignment.cs
public class WritingAssignment : Assignment
{
    private string _title;

    // Constructor to initialize all parameters including the base class attributes
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    // Method to get the writing assignment information
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}

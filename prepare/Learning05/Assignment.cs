// Assignment.cs
public class Assignment
{
    private string _studentName;
    private string _topic;

    // Constructor to initialize student name and topic
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Method to get the summary of the assignment
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // Public method to access the student's name
    public string GetStudentName()
    {
        return _studentName;
    }
}

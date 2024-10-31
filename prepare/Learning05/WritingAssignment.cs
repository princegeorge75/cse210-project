// MathAssignment.cs
public class WritingAssignment : Assignment
{
    private string _title;

    // Constructor
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    // Method to get written information list
    public string GetWritingInformation()
    {
        string studentName = GetstudentName();
        return $"{_title} by {studentName}";
    }
}

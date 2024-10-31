
public class Assignment
{
    private string _studentName;
    private string _topic;

    // Constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Method to get summary
    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }

    // method to get the student name
    public string GetstudentName()
    {
        return _studentName;
    }

    //method to get the topic
    public string GetTopic()
    {
        return _topic;
    }
}

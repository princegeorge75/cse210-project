
public class Video
{
    // Private attributes
    private string _title;
    private string _author;
    private int _length;  // Length in seconds
    private List<Comment> _comments;

    // Constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();  // Initializes an empty list of comments
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to return the number of comments
    public int GetCommentCount()
    {
        return _comments.Count;
    }

    // Method to display video information
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        
        // Display all comments
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
        }
    }
}

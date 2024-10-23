public class Word
{
    private string _text;
    private bool _isHidden;

    // Constructor to initialize the word
    public Word(string text)
    {
        _text = text;
        _isHidden = false;  // By default, the word is not hidden
    }

    // Method to hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Method to check if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Method to display the word or a blank if it is hidden
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return "____";  // Return a blank if the word is hidden
        }
        else
        {
            return _text;  // Return the word if it is not hidden
        }
    }
}

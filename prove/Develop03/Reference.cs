public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    //constructor for a single verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = -1; //means there's no endVerse
    }

    //Constructor for a verse range
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    //Get the display text for the reference
    public string GetDisplayText()
    {
        if (endVerse == -1)
        {
            return $"{book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}
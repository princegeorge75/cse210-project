public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    //Constructor that takes a reference and the text of the scripture
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        //Split the text into individual words and add each word to the list
        string[] wordsArray = text.Split(' ');
        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word));
        }

        //Hide a random number of words in the scripture
        public void HideRandomWords(int numberToHide)
        {
            Random random = new Random();
            for(int i = 0; i < numberToHide; i++)
            {
                int index = random.Next(_words.Count);
                _words[index].Hide();
            }
        }

        //Rwturn the scripture with the hidden words replaced by blanks
        public string GetDisplayText()
        {
            string displayText = _reference.GetDisplayText() + "\n"; //show the reference first
            foreach (Word word in _words)
            {
                displayText += word.GetDisplayText() + " ";
            }
            return displayText.Trim(); //Trim extra spaces at the end
        }
    }

    //Check if all words are hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if(!word.isHidden())
            {
                return false;
            }
        }
        return true;
    }
}
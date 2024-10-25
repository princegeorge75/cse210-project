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
    }

    // Method to hide random number of words in the scripture
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        //Keep trying to hide words untik the desired number is reached
        while (hiddenCount < numberToHide)
        {
            int index = random.Next(_words.Count);

            //Hide the word if it's not already hidden
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
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
    

    //Check if all words are hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if(!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    
}
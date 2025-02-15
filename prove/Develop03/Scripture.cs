public class Scripture
{
    private List<Word> _words = new List<Word>();
    private bool _hidden = false;
    private Verse _verse;

    public Scripture(string book, int chapter, int verse, string text)
    {
        _verse = new Verse(book, chapter, verse);
        _words = new List<Word>();

        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.WriteLine(_verse.GetReference());
        foreach (Word word in _words)
        {
            if (word.isHidden())
            {
                Console.Write("____ ");
            }
            else
            {
                Console.Write($"{word.GetVisible()}" + " ");
            }
        }
    }
    
    private List<Word> GetVisibleWords()
    {
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.isHidden())
            {
                visibleWords.Add(word);
            }
        }
        return visibleWords;
    }
    public bool HideRandomWord()
    {
        List<Word> _words = GetVisibleWords();
        if (_words.Count < 2)
        {
            return false;
        }

        Random random = new Random();
        int index = random.Next(_words.Count);
        _words[index].Hide();
        return true;
    }

  
}
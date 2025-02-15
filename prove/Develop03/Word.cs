public class Word
{
    private string _word;
    private bool _hidden;

    public Word (string word)
    {
        _word = word;
        _hidden = false;

        
    }
    public void Hide()
    {
        _hidden = true;
    }
    public string GetVisible()
    {
        return _word;
    }
    public bool isHidden()
    {
        return _hidden;
    }
}
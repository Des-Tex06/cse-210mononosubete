public class Word
{
    private string _text;
    private bool _isHidden;
    private string _word;
    List<Word> _words = new List<Word>();

    public void AddWord(string word)
    {   
        //_word = word;
        //_words.Add(_word);
    }
    public Word(string text)
    {
        _text = text;
        _isHidden = false;

    }

    public void Hide(bool IsHidden)
    {
        _isHidden = IsHidden;
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }


    public bool IsHidden()
    {
        return true;
    }

    public string GetDisplayText()
    {
        return $"{_text}";
    }
}
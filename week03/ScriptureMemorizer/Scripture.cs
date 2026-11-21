using System.Threading.Channels;

public class Scripture
{
    Reference _reference;
    List<Word> _words = new List<Word>();



    private int _numberToHide;
    private int _positionToHide;
    private string _text;

    Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        

    }
    
    public void AddWord(Word word)
    {   
        Word _text = word;
        _words.Add(_text);
    }

    public void ScriptureVerse()
    {
        
        foreach (Word _word in _words)
        {
            Console.WriteLine(_word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        _numberToHide = numberToHide;
        _numberToHide = 0;
        _positionToHide = 0;
        Random random = new Random();
        _positionToHide = random.Next(0,_words.Count);
        Console.WriteLine(_numberToHide);
        Console.Clear();
        Console.WriteLine("__");


        
    }
    public string GetDisplayText()
    {
        return "";
    }
    public bool IsCompletelyHidden()
    {
        return true;
    }

}
using System.Reflection.Metadata;
using System.Security.Cryptography;

public class Scripture
{
   
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    string _text;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        string theText = text;

        string[] split = theText.Split(" ");

        foreach (string word in split)
        {
            _words.Add(new Word(word));          
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            
            int index = random.Next(0, _words.Count);
            Word word = _words[index];

            
            word.Hide();
        }
    }

    public string GetDisplayText()
    {   
        
        string s = "";
        foreach (Word word in _words)
        {
            s += $"{word.GetDisplayText()} ";
        }
        
        return s;
    }

    public bool AllWordsHidden()
    {
        foreach(Word word in _words ){

            if(!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
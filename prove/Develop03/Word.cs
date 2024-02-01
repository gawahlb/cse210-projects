using System;
using System.Text;

public class Word
{
    private string _text;
    private bool _isHidden;
    private string _hiddenWord;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;

        StringBuilder hiddenWord = new();

        for(int i=0; i<_text.Length; i+=1)
        {
            hiddenWord.Insert(i,"_");
        }

        _hiddenWord = hiddenWord.ToString();

    }

    
    public void Hide()
    {   
        _isHidden = true;
    }


    public bool IsHidden()
    {
        string first = _text.Substring(0,1);
        if(first == "_")
        {
            _isHidden = true;
            return _isHidden;
        }
        else
        {
            _isHidden = false;
            return _isHidden;
        }
    }
    public string GetDisplayText()
    {
        if(_isHidden == true)
        {
            return _hiddenWord;
        }
        else
        {
            return _text;
        }
    }
}
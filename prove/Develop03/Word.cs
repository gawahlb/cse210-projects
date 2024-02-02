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

        foreach (char letter in _text)
        {
            _hiddenWord += "_";
        }        
               

    }

    
    public void Hide()
    {   
        _text = _hiddenWord;
        _isHidden = true;
    }


    public bool IsHidden()
    {
        string first = _text.Substring(0,1);
        if(first == "_")
        {
            _isHidden = true;
        }
        else
        {
            _isHidden = false; 
        }
        return _isHidden;
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
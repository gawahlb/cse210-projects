using System;
using System.IO;

public class Scripture
{
    char sep = ' ';
    private string randWord;
     
    public List<Word> _words = new();
    public Reference _reference;

    public bool CompletelyHidden = false;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        Console.WriteLine("Testing arrayWords");
        string[] arrayWords = text.Split(sep);
        System.Console.WriteLine(arrayWords);
        foreach (string word in arrayWords)
        {
            Word wordObj = new Word(word);
            _words.Add(wordObj);
        }

    }

    private Random random = new();
    private int[] indexList;

    public void HideRandomWords(int numberToHide)
    {
        int index = random.Next(0,_words.Count);

        int currentlyHidden = 0;

        while (IsCompletelyHidden() == false 
            && numberToHide != currentlyHidden)
        {
            if(_words[index].IsHidden() == true)
            {
                
            }
            else 
            {
                _words[index].Hide();
                currentlyHidden += 1;
            }
            index = random.Next(0,_words.Count);
        }

        
     
    }

    public string GetDisplayText()
    {
        string newText2 = "";
        foreach(Word word in _words)
        {
            
            newText2 += word.GetDisplayText() + " ";
        }
        //string newText = string.Join(" ", _words);
        return newText2;

    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }

        return true;
    }













}
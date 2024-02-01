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

        string[] arrayWords = text.Split(sep);
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
        
        List<int> indexList = new();
        if(indexList.Count < numberToHide)
        {
            for(int i = 0; i < 5;)
            {
                int index = random.Next(numberToHide+1);

                if(!indexList.Contains(index))
                {
                    Word randomWord = new Word (randWord);
                    _words[index] = randomWord;
                    i +=1 ;
                    indexList.Add(index);
                }

  
            }
        }
        else
        {
            CompletelyHidden = true;
        }
        

    }

    public string GetDisplayText()
    {
        string newText = string.Join(" ", _words);
        return newText;

    }

    public bool IsCompletelyHidden()
    {
        return CompletelyHidden;
    }













}
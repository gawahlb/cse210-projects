using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference (string book, int chapter, int verse)
    {
        book = _book;
        chapter = _chapter;
        verse = _verse;
    }
    public Reference (string book, int chapter, int startVerse, int endVerse)
    {
        book = _book;
        chapter = _chapter;
        startVerse = _verse;
        endVerse = _endVerse;
    }
    public string GetDisplayText()
    {
        return 
    }
}
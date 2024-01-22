using System;
using System.Collections.Generic;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _entry;


    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"{_prompt}");
        Console.WriteLine($"{_entry}");
    }

}
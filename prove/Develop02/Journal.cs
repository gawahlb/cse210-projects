using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> entries = new();
    private Prompt prompt = new();


    public void AddEntry()
    {
        Entry newEntry = new Entry();
        newEntry._date = DateTime.Now.ToShortDateString();
        newEntry._prompt = prompt.GetRandomPrompt();
        Console.WriteLine(newEntry._prompt);
        Console.WriteLine("Response: ");
        newEntry._entry = Console.ReadLine();
        entries.Add(newEntry);

    }

    public void DisplayAll()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
            Console.WriteLine("\n");
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {

            foreach (Entry entry in entries)
            {
                outputFile.WriteLine(entry._date);
                outputFile.WriteLine(entry._prompt);
                outputFile.WriteLine(entry._entry);
            }

        }

        Console.WriteLine("Entry successfully saved!");
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        for (int i = 0; i < lines.Length; i += 3)
        {
            Entry entry = new();
            entry._date = lines[i];
            entry._prompt = lines[i + 1];
            entry._entry = lines[i + 2];
            entries.Add(entry);
        }

    }
}
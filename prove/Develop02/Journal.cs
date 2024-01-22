using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    List<string> entries = new List<string>();


    public void AddEntry()
    {



    }

    public void DisplayAll()
    {



    }

    public void SaveToFile(string )
    {

        string fileName = "entries.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {

            outputFile.WriteLine($"{newEntry}");

        }

    }

    public void LoadFromFile()
    {

        

    }
}
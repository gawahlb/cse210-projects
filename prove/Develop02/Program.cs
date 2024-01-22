using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        string returnedPrompt = Prompt.GetRandomPrompt;

        Entry newEntry = new Entry();
        newEntry._date = dateText;
        newEntry._prompt = Prompt.GetRandomPrompt;
        newEntry._entry = "";
        
    }
}
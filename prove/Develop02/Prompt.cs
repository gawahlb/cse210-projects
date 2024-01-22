using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Prompt
{
    List<string> prompts = new List<string>();


    public string GetRandomPrompt()
    {
        prompts.Add("How have I seen the Lord's hand in my life today?");
        prompts.Add("What is something I was able to accomplish today?");
        prompts.Add("What is something I am grateful for today?");
        prompts.Add("What was the most exciting part of my day?");
        prompts.Add("What would I change about my day?");
        
        var random = new Random();
        int randomPrompt = random.Next(prompts.Count);
        return prompts[randomPrompt];

    }
}
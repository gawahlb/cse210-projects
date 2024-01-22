using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Prompt
{
    private List<string> prompts = new List<string>()
    {
        "How have I seen the Lord's hand in my life today?",
        "What is something I was able to accomplish today?",
        "What is something I am grateful for today?",
        "What was the most exciting part of my day?",
        "What would I change about my day?"
    };
    private Random random = new Random();

    public string GetRandomPrompt()
    {
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}
using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions) : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {
        Console.Clear();
        int time = 0;
        ReflectingActivity c = new("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", time, _prompts, _questions);
        System.Console.WriteLine("Welcome to the Reflecting Activity.");
        System.Console.WriteLine("");
        System.Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        System.Console.WriteLine(" ");
        System.Console.WriteLine("How long, in seconds, would you like for your session?");
        string response = Console.ReadLine();
        time = int.Parse(response);

        Console.WriteLine("Prepare to begin...");
        c.ShowSpinner(5);
        Console.Clear();
        Console.WriteLine("Consider the following prompt:");
        System.Console.WriteLine("");
        Console.WriteLine($"---{c.GetRandomPrompt()}---");
        System.Console.WriteLine("");
        System.Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Clear();
        
        System.Console.WriteLine("Now ponder on each of the following questions as the relate to this experience.");
        System.Console.WriteLine("You may begin in: ");
        c.ShowCountDown(5);
        Console.Clear();

        DateTime start = DateTime.Now;
        DateTime future = start.AddSeconds(time);
        
        while(start < future)
        {
        Console.WriteLine($"> {c.GetRandomQuestion()}");
        c.ShowSpinner(10);
        start = DateTime.Now;
        }
        
        System.Console.WriteLine("");
        System.Console.WriteLine("Well done!");
        System.Console.WriteLine("");
        c.ShowSpinner(3);

        

    }

    public string GetRandomPrompt()
    {
        _prompts.Add("Think of a time when you did something truly selfless.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you stood up for someone else.");

        Random random = new();
        int index = random.Next(0, _prompts.Count);

        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        Random random = new();
        int index = random.Next(0, _questions.Count);

        return _questions[index];
    }

    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine($"---{prompt}---");
    }

    public void DisplayQuestion(string question)
    {
        System.Console.WriteLine($"---{question}---");
    }









}
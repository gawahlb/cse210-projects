using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration, int count, List<string> prompts) : base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;
    }

    public void Run()
    {
        Console.Clear();
        int time = 0;
        ListingActivity b = new("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", time, _count, _prompts);
        System.Console.WriteLine("Welcome to the Listing Activity.");
        System.Console.WriteLine("");
        System.Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        System.Console.WriteLine(" ");
        System.Console.WriteLine("How long, in seconds, would you like for your session?");
        string response = Console.ReadLine();
        time = int.Parse(response);

        Console.WriteLine("Prepare to begin...");
        b.ShowSpinner(5);

        Console.Clear();
        DateTime start = DateTime.Now;
        DateTime future = start.AddSeconds(time);
        Console.WriteLine("List as many responses as you can to the following prompt:");
        System.Console.WriteLine("");
        System.Console.WriteLine($"---{b.GetRandomPrompt()}---");
        System.Console.WriteLine("");

        System.Console.WriteLine("You may begin in: ");
        b.ShowCountDown(5);

        b.GetListFromUser(time);


    }
    public string GetRandomPrompt()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("Who are some of your personal heroes?");
        _prompts.Add("When have you felt the Holy Ghost this month?");

        Random random = new();
        int index = random.Next(0, _prompts.Count);

        return _prompts[index];

    }
    public List<string> GetListFromUser(int time)
    {
        List<string> responses = new();

        DateTime start = DateTime.Now;
        DateTime future = start.AddSeconds(time);
        
        while(start < future)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            responses.Add(response);
            start = DateTime.Now;
        }
        Console.WriteLine("");
        
        _count = responses.Count;

        Console.WriteLine($"Well done! You gave {_count} responses!");
        Thread.Sleep(3000);

        return responses;


    }
}
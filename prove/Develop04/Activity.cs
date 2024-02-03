using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage(string startingMessage)
    {
        Console.WriteLine($"Welcome to the {startingMessage}.");

    }

    public void DisplayEndingMessage(string endingMessage)
    {
        Console.WriteLine($"Thank you for participating in the {endingMessage}!");
    }

    public void ShowSpinner(int seconds)
    {
        DateTime start = DateTime.Now;
        DateTime future = start.AddSeconds(seconds); 
        
        while(start != future)
        {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            start = start.AddSeconds(1);
        }

    }

    public void ShowCountDown(int seconds)
    {
        DateTime start = DateTime.Now;
        DateTime future = start.AddSeconds(seconds);
        int counter = 1;

        while(start != future)
        {
            Console.Write($"{seconds}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            counter += 1;
            seconds -= 1;
            start = start.AddSeconds(1);
        } 
    }


}

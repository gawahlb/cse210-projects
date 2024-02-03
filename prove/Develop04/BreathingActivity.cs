using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        
    }

    public void Run()
    {
        Console.Clear();
        int time = 0;

        BreathingActivity a = new("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", time);
        
        System.Console.WriteLine("Welcome to the Breathing Activity.");
        System.Console.WriteLine("");
        System.Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        System.Console.WriteLine("");
        Console.WriteLine("How long, in seconds, would you like for your session?");
        string response = Console.ReadLine();
        System.Console.WriteLine(" ");
        time = int.Parse(response);

        Console.Clear();
        Console.WriteLine("Prepare to begin...");
        a.ShowSpinner(5);
        
        DateTime start = DateTime.Now;
        DateTime future = start.AddSeconds(time);

        while (start < future)
        {
            Console.WriteLine("Breathe in...");
            a.ShowCountDown(4);
            //Thread.Sleep(4000);
            Console.WriteLine("Breathe out...");
            a.ShowCountDown(6);
            //Thread.Sleep(6000);
            start = start.AddSeconds(10);
        }
    }


}
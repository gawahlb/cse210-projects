using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        name = "Breathing Activity";
        description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        duration = int.Parse(Console.ReadLine());
    }

    public void Run()
    {
        BreathingActivity a = new();
        DateTime start = DateTime.Now;
        DateTime future = start.AddSeconds(duration);

        while (start != future)
        {
            Console.Write("Breathe in...");
            Thread.Sleep(4000);
            Console.Write("\b \b");
            Console.Write("Breathe out...");
            Thread.Sleep(6000);
            Console.Write("\b \b");
        }

    }


}
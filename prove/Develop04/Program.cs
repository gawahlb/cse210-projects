using System;

class Program
{
    static void Main(string[] args)
    {
        string option = "";
        string name = "";
        string message = "";
        int time = 0;
        List<string> prompts = new();
        List<string> questions = new();
        int count = 0;

        while(option != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            System.Console.WriteLine("   1. Start breathing activity");
            System.Console.WriteLine("   2. Start reflecting activity");
            System.Console.WriteLine("   3. Start listing activity");
            System.Console.WriteLine("   4. Quit");
            System.Console.WriteLine("Select a choice from the menu: ");
            option = Console.ReadLine();
            switch(option)
            {
                case "1":
                    name = "Breathing Activity";
                    message = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
                    BreathingActivity a = new(name, message, time);
                    a.Run();
                    System.Console.WriteLine(" ");
                    a.DisplayEndingMessage(name);
                    a.ShowSpinner(5);
                    break;
                
                case "2":
                    name = "Reflecting Activity";
                    message = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                    ReflectingActivity c = new(name, message, time, prompts, questions);
                    c.Run();
                    System.Console.WriteLine("");
                    c.DisplayEndingMessage(name);
                    c.ShowSpinner(5);
                    break;

                case "3":
                    name = "Listing Activity";
                    message = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                    ListingActivity b = new(name, message, time, count, prompts);
                    b.Run();
                    System.Console.WriteLine("");
                    b.DisplayEndingMessage(name);
                    b.ShowSpinner(5);
                    break;



            }








        }
        


        



    }
}
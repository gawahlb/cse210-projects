using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new();
        string choice = "";

        while(choice != "6")
        {
            Console.WriteLine("");
            goalManager.DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.WriteLine("Select a choice from the menu:");
            choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                    goalManager.CreateGoal();
                    break;

                case "2":
                    goalManager.ListGoalDetails();
                    break;

                case "3":
                    goalManager.SaveGoals();
                    break;
                
                case "4":
                    goalManager.LoadGoals();
                    break;
                case "5":
                    goalManager.RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("See you next time!");
                    break;
                default:
                    Console.WriteLine("Invalid Input. Please try again!");
                    break;

            }


        }
        
    }
}
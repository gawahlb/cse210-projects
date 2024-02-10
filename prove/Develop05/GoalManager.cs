using System;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals= new List<Goal>();
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalDetails()
    {
        int counter = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{counter}. {goal.GetDetailsString()}");
            counter += 1;
        }
    }

    public void CreateGoal()
    {
        string name;
        string description;
        int points;
        int target;
        int bonus;

        Console.WriteLine("\nWhich type of goal would you like to create?");
        Console.WriteLine("\nThe types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        string option = Console.ReadLine();
    
        if(option == "1")
        {
            Console.WriteLine("What is the name of your goal?");
            name = Console.ReadLine();
            Console.WriteLine("What is a short description of it?");
            description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal?");
            points = int.Parse(Console.ReadLine());
            SimpleGoal a = new(name, description, points, false);
            _goals.Add(a);

        }
        else if(option == "2")
        {      
            Console.WriteLine("What is the name of your goal?");
            name = Console.ReadLine();
            Console.WriteLine("What is a short description of it?");
            description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal?");
            points = int.Parse(Console.ReadLine());
            EternalGoal a = new(name, description, points, false);
            _goals.Add(a);
        }

        else if(option == "3")
        {
           Console.WriteLine("What is the name of your goal?");
            name = Console.ReadLine();
            Console.WriteLine("What is a short description of it?");
            description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal?");
            points = int.Parse(Console.ReadLine());
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
            target = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for accomplishing it that many times?");
            bonus = int.Parse(Console.ReadLine());
            ChecklistGoal a = new(name, description, points, false, 0, target, bonus);
            _goals.Add(a);
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
            
    }
    

    public void RecordEvent()
    {
        ListGoalDetails();
        Console.WriteLine("Which goal did you accomplish?");
        int choice = int.Parse(Console.ReadLine());
        _score += _goals[choice - 1].RecordEvent();
    }

    public void SaveGoals()
    {
        Console.WriteLine("What is the filename for the goal file?");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {

            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }

        }

        Console.WriteLine("Goals saved successfully!");
    }
    public void LoadGoals()
    {
        Console.WriteLine("What is the filename for the goal file?");
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);
        _goals.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if(parts[0] == "SimpleGoal")
            {
                SimpleGoal goal = new(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                _goals.Add(goal);
            }
            else if(parts[0] == "EternalGoal")
            {
                EternalGoal goal = new(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                _goals.Add(goal);
            }
            else if(parts[0] == "ChecklistGoal")
            {
                ChecklistGoal goal = new(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]));
                _goals.Add(goal);
            }
        }
    }
}
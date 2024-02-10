using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points, bool isComplete) : base(name, description, points, isComplete){}

    public override int RecordEvent()
    {
        Console.WriteLine($"You have earned {_points} points! Great job!");
        return _points;
    }

    public override string GetStringRepresentation()
    {
        return $"{GetType()}|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}
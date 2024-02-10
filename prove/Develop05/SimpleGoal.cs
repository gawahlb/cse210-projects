using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points, isComplete) {}

    public override string GetStringRepresentation()
    {
        return $"{GetType()}|{_shortName}|{_description}|{_points}|{_isComplete}";
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"You have earned {_points} points! Great job!");
        return _points;
    }
}
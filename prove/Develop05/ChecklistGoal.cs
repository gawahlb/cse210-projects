using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, bool isComplete, int amountCompleted, int target, int bonus) : base(name, description, points, isComplete)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"{GetType()}|{_shortName}|{_description}|{_points}|{_isComplete}|{_amountCompleted}|{_target}|{_bonus}";
    }

    public override int RecordEvent()
    {
        Console.WriteLine("How many times have you completed this goal since last time you checked in?");
        int currentTimes = int.Parse(Console.ReadLine());
        _amountCompleted += currentTimes;

        if(_amountCompleted == _target)
        {
            _isComplete = true;
            Console.WriteLine($"You have earned {(_points*currentTimes)+_bonus} points. Congratulations on completing this goal!");
            return (_points*currentTimes) + _bonus;
        }
        else
        {
            Console.WriteLine($"You have earned {_points*currentTimes} Good job on your progress!");
            return _points*currentTimes;
        }
    }
}
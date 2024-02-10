using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    public Goal(string name, string description, int points, bool isComplete)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }
    public bool IsComplete()
    {
        return _isComplete;
    }
    public abstract int RecordEvent();
    public virtual string GetDetailsString()
    {
        if(_isComplete == true)
        {
        return $"[X] {_shortName} ({_description})";
        }
        else
        {
           return $"[ ] {_shortName} ({_description})"; 
        }
    }
    public abstract string GetStringRepresentation();
}
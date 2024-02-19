using System;

public abstract class Maker
{
    protected string _name;
    protected string _description;
    protected bool _isUsed;

    public Maker(string name, string description, bool isUsed)
    {
        _name = name;
        _description = description;
        _isUsed = isUsed;
    }
    public bool IsUsed()
    {
        return _isUsed;
    }
    public abstract string GetDetails();
    public abstract string GetRepresentation();
    public abstract void Pack(string name);
    public abstract void Unpack();
}
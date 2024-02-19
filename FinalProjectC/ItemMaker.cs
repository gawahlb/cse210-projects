using System;

public class ItemMaker : Maker
{
    protected string _containedIn;
    public ItemMaker(string name, string description, bool isUsed, string containedIn) : base(name, description, isUsed)
    {
        _containedIn = containedIn;
    }
    public string ContainedIn()
    {
        return _containedIn;
    }

    public override string GetDetails()
    {
        return $"{_name} - ({_description})";
    }

    public override string GetRepresentation()
    {
        return $"{_name}|{_description}|{_isUsed}|{_containedIn}";
    }

    public override void Pack(string name)
    {
        _isUsed = true;
        _containedIn = name;
    }

    public override void Unpack()
    {
        _isUsed = false;
        _containedIn = "";
    }
    
}
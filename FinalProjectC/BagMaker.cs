using System;

public class BagMaker : Maker
{
    public BagMaker(string name, string description, bool isUsed) : base(name, description, isUsed)
    {
    }

    public override string GetDetails()
    {
        return $"{_name} - ({_description})";
    }

    public override string GetRepresentation()
    {
        return $"{_name}|{_description}|{_isUsed}";
    }

    public override void Pack(string name)
    {
        _isUsed = true;
    }

    public override void Unpack()
    {
        _isUsed = false;
    }
}
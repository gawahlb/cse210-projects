using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a = new Assignment("Gabe Wahlberg", "Programming");
        Console.WriteLine(a.GetSummary());

        MathAssignment b = new MathAssignment("Gabe Wahlberg", "Programming", "1.1", "1-4");
        Console.WriteLine(b.GetSummary());
        Console.WriteLine(b.GetHomeworkList());

        WritingAssignment c = new WritingAssignment("Gabe Wahlberg", "Programming", "Programming");
        Console.WriteLine(c.GetSummary());
        Console.WriteLine(c.GetWritingInformation());



    }
}
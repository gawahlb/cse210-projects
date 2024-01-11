using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string grade = Console.ReadLine();

        float percent = float.Parse(grade);

        string letter;

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent < 90 && percent > 80 )
        {
            letter = "B";
        }
        else if (percent < 80 && percent > 70 )
        {
            letter = "C";
        }
        else if (percent < 70 && percent > 60 )
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}.");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You have passed this class!");
        }
        else
        {
            Console.WriteLine("I'm sorry, you did not pass this class. Keep studying for next time!");
        }

    }
}
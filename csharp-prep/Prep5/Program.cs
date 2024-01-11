using System;
using System.Globalization;

class Program
{
    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        string num = Console.ReadLine();

        int number = int.Parse(num);
        return number;
    }

    static int SquareNumber(int number)
    {
        int sq_num = number*number;
        return sq_num;
    }

    static void DisplayResult(string name, int sq_num)
    {
        Console.WriteLine($"{name}, the square of your number is {sq_num}.");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUserNumber();
        int sq_num = SquareNumber(number);
        DisplayResult(name, sq_num);
    }
}
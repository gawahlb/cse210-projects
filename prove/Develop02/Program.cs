using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        string option = "";
        Journal journal = new();

        while (option != "5")
        {

            Console.WriteLine("Welcome to your Journal App! What would you like to do?");
            Console.WriteLine("1) Add Entry");
            Console.WriteLine("2) Display Entries");
            Console.WriteLine("3) Save");
            Console.WriteLine("4) Load");
            Console.WriteLine("5) Quit");
            option = Console.ReadLine();

            switch(option)
            {
                case "1":
                    journal.AddEntry();
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    journal.SaveToFile("entrydata.txt");
                    break;
                case "4":
                    journal.LoadFromFile("entrydata.txt");
                    break;
                case "5":
                    Console.WriteLine("See you next time!");
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
        }
        
    }
}
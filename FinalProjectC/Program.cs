using System;

class Program
{
    static void Main(string[] args)
    {
        Manager manager = new();
        string choice = "";

        while(choice != "8")
        {
            Console.WriteLine("");
            manager.Update();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Item or Bag");
            Console.WriteLine("  2. Delete Item or Bag");
            Console.WriteLine("  3. List Items");
            Console.WriteLine("  4. List Bags");
            Console.WriteLine("  5. Load");
            Console.WriteLine("  6. Save");
            Console.WriteLine("  7. Move Item");
            Console.WriteLine("  8. Quit");
            Console.WriteLine("Select a choice from the menu:");
            choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                    manager.Create();
                    break;

                case "2":
                    manager.Delete();
                    break;

                case "3":
                    manager.DisplayItemDetails();
                    break;
                
                case "4":
                    manager.DisplayBagDetails();
                    break;
                case "5":
                    manager.Load();
                    break;
                case "6":
                    manager.Save();
                    break;
                case "7":
                    manager.MoveItem();
                    break;
                case "8":
                    Console.WriteLine("See you next time!");
                    break;
                default:
                    Console.WriteLine("Invalid Input. Please try again!");
                    break;

            }


        }
        
    }
}
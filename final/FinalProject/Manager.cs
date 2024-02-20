using System;

public class Manager
{
    private List<ItemMaker> _items;
    private List<BagMaker> _bags;

    public Manager ()
    {
        _items = new List<ItemMaker>();
        _bags = new List<BagMaker>();
    }

    public void Create()
    {
        Console.WriteLine("What would you like to create?");
        Console.WriteLine(" 1. Item");
        Console.WriteLine(" 2. Bag");
        string option = Console.ReadLine();

        if(option == "1")
        {
            Console.WriteLine("Please write the name of the item that you would like to create:");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter a description for this item");
            string description = Console.ReadLine();
            Console.WriteLine("Which bag would you like to pack this item in? (If none yet, press enter without typing anything)");
            string containedIn = Console.ReadLine();

            if(containedIn.Length >= 1)
            {
                ItemMaker a = new(name, description, true, containedIn);
                _items.Add(a);
            }
            else
            {
                ItemMaker a = new(name, description, false, containedIn);
                _items.Add(a);
            }
        }
        else if(option == "2")
        {
            Console.WriteLine("Please write the name of the bag that you would like to create:");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter a description for this bag");
            string description = Console.ReadLine();
            BagMaker a = new(name, description, false);
            _bags.Add(a);
        }
        else
        {
            Console.WriteLine("Invalid Input.");
        }
        
    }

    public void Delete()
    {
        int counter = 1;
        int choice;
        Console.WriteLine("What would you like to delete?");
        Console.WriteLine(" 1. Item");
        Console.WriteLine(" 2. Bag");
        string option = Console.ReadLine();

        if(option == "1")
        {
            Console.WriteLine("Which item would you like to delete?");
            foreach (ItemMaker item in _items)
            {
                Console.WriteLine($"{counter}. {item.GetDetails()}");
                counter += 1;
            }
            choice = int.Parse(Console.ReadLine());
            _items.Remove(_items[choice-1]);
        }
        else if(option == "2")
        {
            Console.WriteLine("Which bag would you like to delete?");
            foreach (BagMaker bag in _bags)
            {
                Console.WriteLine($"{counter}. {bag.GetDetails()}");
                counter += 1;
            }
            choice = int.Parse(Console.ReadLine());

            if(_bags[choice -1].IsUsed() == true)
            {
                Console.WriteLine("What would you like to do with the items currently in this bag?");
                Console.WriteLine(" 1. Delete All");
                Console.WriteLine(" 2. Unpack All");

                string a = Console.ReadLine();

                if(a == "1")
                {
                    _bags.Remove(_bags[choice-1]);
                }
                else if(a == "2")
                {
                    string bagName = _bags[choice].GetRepresentation();
                    string[] parts = bagName.Split('|');

                    foreach(ItemMaker item in _items)
                    {
                        if(item.ContainedIn() == parts[0])
                        {
                            item.Unpack();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input.");
                }
            }
            else
            {
                _bags.Remove(_bags[choice-1]);
            }
            
            
        }
        
    }

    public void DisplayItemDetails()
    {
        int counter = 1;
        foreach (ItemMaker item in _items)
        {
            Console.WriteLine($"{counter}. {item.GetDetails()} - {item.ContainedIn()}");
            counter += 1;
        }
    }

    public void DisplayBagDetails()
    {
        int counter = 1;
        foreach (BagMaker bag in _bags)
        {
            Console.WriteLine($"{counter}. {bag.GetDetails()}");
            
            foreach(ItemMaker item in _items)
            {
                string itemName = item.GetRepresentation();
                string[] parts = itemName.Split('|');

                string bagName = bag.GetRepresentation();
                string[] sections = bagName.Split('|');


                if(parts[4] == sections[1])
                {
                    Console.WriteLine($"          {parts[1]}");
                }
            }

            counter += 1;
        }
    }

    public void Load()
    {
        Console.WriteLine("What is the filename for the items file?");
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);
        _items.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if(parts[0] == "Item")
            {
                ItemMaker item = new(parts[1], parts[2], bool.Parse(parts[3]), parts[4]);
                _items.Add(item);
            }
            else
            {
                BagMaker bag = new(parts[1], parts[2], bool.Parse(parts[3]));
                _bags.Add(bag);
            }
        }
        Console.WriteLine("File loaded successfully!");
    }

    public void Save()
    {
        Console.WriteLine("What do you want the filename to be?");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(ItemMaker item in _items)
            {
                outputFile.WriteLine(item.GetRepresentation());
            }
            foreach(BagMaker bag in _bags)
            {
                outputFile.WriteLine(bag.GetRepresentation());
            }
        }
        Console.WriteLine("Saved successfully!");
    }
    public void MoveItem()
    {
        string choice;
        Console.WriteLine("What type of item would you like to move?");
        Console.WriteLine(" 1. An item currently in a bag");
        Console.WriteLine(" 2. An item currently unpacked");
        choice = Console.ReadLine();

        if(choice == "1")
        {
            int itemsPacked = 0;
            int itemNumber = 0;
            foreach(ItemMaker item in _items)
            {
                if(item.IsUsed() == true)
                {
                    itemsPacked += 1;
                }
                itemNumber += 1;
            }
            if(itemsPacked > 0)
            {
                int option;
                int counter = 0;
                Console.WriteLine("Which item would you like to move?");
                foreach (ItemMaker item in _items)
                {
                    counter += 1;
                    if(item.IsUsed() == true)
                    {
                        Console.WriteLine($"{counter}. {item.GetDetails()}");
                    }
                }
                option = int.Parse(Console.ReadLine());

                int bagcounter = 1;
                Console.WriteLine("Where would you like to move it?");
                foreach (BagMaker bag in _bags)
                {
                    Console.WriteLine($"{bagcounter}. {bag.GetDetails()}");
                    bagcounter += 1;
                }
                int moveTo = int.Parse(Console.ReadLine());

                string bagName = _bags[moveTo-1].GetRepresentation();
                string[] parts = bagName.Split('|');
                string itemName = _items[option-1].GetRepresentation();
                string[] sections = itemName.Split('|');

                _items[option-1].Pack(parts[1]);
                _bags[moveTo-1].Pack(sections[1]);
                Console.WriteLine("Item moved successfully!");
            }
            else
            {
                Console.WriteLine("You don't have any packed items yet!");
            }
        }
        else if(choice == "2")
        {
            int itemsUnpacked = 0;
            foreach(ItemMaker item in _items)
            {
                if(item.IsUsed() == false)
                {
                    itemsUnpacked += 1;
                }
            }

            if(itemsUnpacked > 0)
            {
                int option;
                int counter = 0;
                Console.WriteLine("Which item would you like to move?");
                foreach (ItemMaker item in _items)
                {
                    counter += 1;
                    if(item.IsUsed() == false)
                    {
                        Console.WriteLine($"{counter}. {item.GetDetails()}");
                    }
                }
                option = int.Parse(Console.ReadLine());

                int bagcounter = 1;
                Console.WriteLine("Where would you like to move it?");
                foreach (BagMaker bag in _bags)
                {
                    Console.WriteLine($"{bagcounter}. {bag.GetDetails()}");
                    bagcounter += 1;
                }
                int moveTo = int.Parse(Console.ReadLine());

                string bagName = _bags[moveTo-1].GetRepresentation();
                string[] parts = bagName.Split('|');

                string itemName = _items[option-1].GetRepresentation();
                string[] sections = itemName.Split('|');

                _items[option-1].Pack(parts[1]);
                _bags[moveTo-1].Pack(sections[1]);
                Console.WriteLine("Item moved successfully!");
            }
            else
            {
                Console.WriteLine("You don't have any items that are unpacked!");
            }
        }
        else
        {
            Console.WriteLine("Invalid Input.");
        }
    }
    public void Update()
    {
        int counter = 0;
        foreach(ItemMaker item in _items)
        {
            if(item.IsUsed() == false)
            {
                counter += 1;
            }
        }
        if(counter > 0)
        {
        Console.WriteLine($"Warning! You have {counter} unpacked items!");
        }
    }
}
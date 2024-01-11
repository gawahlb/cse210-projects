using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        int num = 1;

        while (num != 0)
        {
            Console.WriteLine("Enter number: ");
            string user_num = Console.ReadLine();

            num = int.Parse(user_num);

            numbers.Add(num);
        }

        int sum = 0;

        foreach (int number in numbers)
        {
            sum = sum + number;
        }

        Console.WriteLine($"The sum is: {sum}");

        int num_count = numbers.Count;

        float avg = ((float)sum) / num_count;

        Console.WriteLine($"The average is: {avg}");

        int new_num = 0;

        foreach (int number in numbers)
        {
            if (number > new_num)
            {
                new_num = number;
            }
        }
        
        Console.WriteLine($"The largest number is: {new_num}");
    }
}
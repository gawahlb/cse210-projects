using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int num = randomGenerator.Next(1,100);

        Console.WriteLine("I'm thinking of a Magic Number between 1 and 100.");

        Console.WriteLine("What do you think the magic number is?");
        string user_guess = Console.ReadLine();

        int guess = int.Parse(user_guess);

        while (guess != num)
        {
            if (guess > num)
            {
                Console.WriteLine("That's too high! Guess again: ");
                string new_guess = Console.ReadLine();

                guess = int.Parse(new_guess);
            }
            else
            {
                Console.WriteLine("That's too low! Guess again: ");
                string new_guess = Console.ReadLine();

                guess = int.Parse(new_guess);
            }
        }

        Console.WriteLine("You guessed correctly! Great job!");
    
    }
}
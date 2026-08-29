using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise 3 Project.");
        int magicNumber = 0;
        int guess = -1;
        Console.WriteLine("Try to guess the Magic Number!");
        Console.Write("What is the Magic Number? ");
        magicNumber = int.Parse(Console.ReadLine());
        Console.WriteLine($"TESTING: Your Magic Number is {magicNumber}!");
        string response;

        do
        {
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        } while (response == "no");
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (guess == magicNumber)
            {
                Console.WriteLine("Congratulations! You guessed the Magic Number!");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher...");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower...");
            }
            else
            {
                Console.WriteLine("Something went wrong with your guess. Please try again.");
            }
    }
}
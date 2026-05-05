using System;

class Program
{
    static void Main(string[] args)
    {
        string percentageString = " ";
        int percentageInt = -1;
        string letter = " ";
        Console.WriteLine("Hello World! This is the Exercise 2 Project.");

        Console.Write("Please enter your grade percentage as a whole number: ");
        percentageString = Console.ReadLine();
        percentageInt = int.Parse(percentageString);
        if (percentageInt >= 90)
        {
            letter = "A";
        }
        else if (percentageInt >= 80)
        {
            letter = "B";
        }
        else if (percentageInt >= 70)
        {
            letter = "C";
        }
        else if (percentageInt >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.Write($"Your letter grade is: {letter}. ");
        if (percentageInt >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass the class. Better luck next time!");
        }
    }
}
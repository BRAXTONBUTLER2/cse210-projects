using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello and welcome to my program! ");  // Fixed missing semicolon
        Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();
        Console.WriteLine($"Hello {firstname}");

        Console.Write("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine($"Your favorite number is {number}");

        int square = SquareNumber(number);
        DisplayResult(firstname, square);
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}

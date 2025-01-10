using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What grade did you get in the class?");
        string input = Console.ReadLine();

        // Try parsing the input to an integer
        if (int.TryParse(input, out int grade))
        {
            if (grade >= 95 && grade <= 100)
            {
                Console.WriteLine("You got an A+");
            }
            else if (grade >= 90 && grade < 95)
            {
                Console.WriteLine("You got an A");
            }
            else if (grade >= 80 && grade < 90)
            {
                Console.WriteLine("You got a B");
            }
            else if (grade >= 70 && grade < 80)
            {
                Console.WriteLine("You got a C");
            }
            else if (grade >= 0 && grade < 70)
            {
                Console.WriteLine("You did not pass.");
            }
            else
            {
                Console.WriteLine("Grade out of range. Please enter a grade between 0 and 100.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric grade.");
        }
    }
}

using System;
// MY STRECTH GOALS INCLUDED, ADDING A LOG TO SEE HOW MANY TIMES YOU PREFORMED A TASK AND ALSO MAKING IT SO YOU DID NOT GET REPEATS
class Program
{
    static void Main(string[] args)
    {
        int breatheCount = 0;
        int reflectCount = 0;
        int listCount = 0;

        // Welcome message
        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine();
        
        bool isRunning = true;
        
        while (isRunning)
        {
            // Display menu options
            DisplayMenu();

            // Get user input
            int choice = GetUserChoice();
            Console.WriteLine();

            // Process user choice
            switch (choice)
            {   
                case 1:
                    // Breathing Activity
                    PerformBreathingActivity(ref breatheCount);
                    break;

                case 2:
                    // Reflecting Activity
                    PerformReflectingActivity(ref reflectCount);
                    break;

                case 3:
                    // Listing Activity
                    PerformListingActivity(ref listCount);
                    break;

                case 4:
                    // Quit program
                    QuitProgram(breatheCount, reflectCount, listCount);
                    isRunning = false;
                    break;

                default:
                    // Invalid choice
                    Console.WriteLine("Invalid input. Please choose one of the following activities.");
                    break;
            }
        }
    }

    // Method to display the activity menu
    static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Please select one of the following activities: ");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine();
    }

    // Method to get and validate user input
    static int GetUserChoice()
    {
        int choice;
        while (true)
        {
            Console.Write("What would you like to do? ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out choice) && choice >= 1 && choice <= 4)
            {
                return choice;
            }
            else
            {
                Console.WriteLine("Invalid choice, please enter a number between 1 and 4.");
            }
        }
    }

    // Method to handle the Breathing Activity
    static void PerformBreathingActivity(ref int breatheCount)
    {
        Console.Clear();
        BreathingActivity breathing = new BreathingActivity();
        breathing.RunBreathingActivity();
        breatheCount++;
    }

    // Method to handle the Reflecting Activity
    static void PerformReflectingActivity(ref int reflectCount)
    {
        Console.Clear();
        ReflectingActivity reflection = new ReflectingActivity();
        reflection.RunReflectingActivity();
        reflectCount++;
    }

    // Method to handle the Listing Activity
    static void PerformListingActivity(ref int listCount)
    {
        Console.Clear();
        ListingActivity listing = new ListingActivity();
        listing.RunListingActivity();
        listCount++;
    }

    // Method to quit and display the number of activities completed
    static void QuitProgram(int breatheCount, int reflectCount, int listCount)
    {
        Console.Clear();
        Console.WriteLine("Great job! You completed the following activities: ");
        Console.WriteLine($"Breathing Activity: {breatheCount} times");
        Console.WriteLine($"Reflecting Activity: {reflectCount} times");
        Console.WriteLine($"Listing Activity: {listCount} times");
        Console.WriteLine();
        Console.WriteLine("Thank you. Have a nice day!");
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using DailyJournal;


class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        // List of prompts to choose from genterated new ones
        List<string> prompts = new List<string>
        {
            "What moment today made you feel grateful and why?",
"Did you face any fears today? How did it make you feel?",
"What was the most rewarding part of your day?",
"Who inspired you today and what did they teach you?",
"What new skill or knowledge did you acquire today?",
"What act of kindness did you experience or witness today?",
"Did you feel proud of something you accomplished today?",
"How did you step outside your comfort zone today?",
"What is one thing you would like to change about your routine?",
"What would you like to learn more about tomorrow?",
"How did you show gratitude to others today?",
"Did you feel a sense of peace or calmness today? What helped you feel that way?",
"What was the most thought-provoking thing you saw or heard today?",
"How did you connect with others today, and how did it impact you?",
"What spiritual practice or moment brought you comfort today?"

        };

        bool quit = false;
        while (!quit)
        {
            // Display menu and change color
            Console.ForegroundColor = ConsoleColor.Cyan;
           Console.WriteLine(@"
______     _            _           ___                              _ 
| ___ \   (_)          | |         |_  |                            | |
| |_/ / __ ___   ____ _| |_ ___      | | ___  _   _ _ __ _ __   __ _| |
|  __/ '__| \ \ / / _` | __/ _ \     | |/ _ \| | | | '__| '_ \ / _` | |
| |  | |  | |\ V / 1_| | ||  __/ /\__/ / (_) | |_| | |  | | | | (_) | |
\_|  |_|  |_| \_/ \__,_|\__\___| \____/ \___/ \__,_|_|  |_| |_|\__,_|_|
");
            Console.WriteLine("1. Write an Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal to File");
            Console.WriteLine("4. Load Journal from File");
            Console.WriteLine("5. Quit");
            Console.Write("\nWhat would you like to do? ");

            string choice = Console.ReadLine();

            //  user input stuffs
            switch (choice)
            {
                case "1":
                    string prompt = GetRandomPrompt(prompts);
                    journal.AddEntry(prompt);
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    journal.SaveToFile();
                    break;
                case "4":
                    journal.LoadFromFile();
                    break;
                case "5":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
        Console.WriteLine("Goodbye! Keep journaling!");
    }

    // Selects a random prompt from the list
    static string GetRandomPrompt(List<string> prompts)
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}

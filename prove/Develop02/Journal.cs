using System;
using System.Collections.Generic;
using System.IO;

namespace DailyJournal
{
    class Journal
    {
        private List<Entry> entries; // List to store journal entries

        
        public Journal()
        {
            entries = new List<Entry>();
        }

        // should a new entry based on a given prompt
        public void AddEntry(string prompt)
        {
            Console.Write(prompt + " ");
            string response = Console.ReadLine();
            string date = DateTime.Now.ToString("MM/dd/yyyy");

            // Create a new Entry object and add it to the list
            Entry newEntry = new Entry(prompt, response, date);
            entries.Add(newEntry);
        }

        // Displays all journal entries with date and prompt
        public void DisplayEntries()
        {
            if (entries.Count == 0)
            {
                Console.WriteLine("No entries to display.");
            }
            else
            {
                foreach (Entry entry in entries)
                {
                    Console.WriteLine(entry.ToString());
                }
            }
        }

        // Save the entry to a file
        public void SaveToFile()
        {
            Console.Write("Enter filename: ");
            string filename = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine("Date|Prompt|Response"); // Using "|" as a delimiter to avoid issues with commas
                foreach (Entry entry in entries)
                {
                    writer.WriteLine($"{entry.GetDate()}|{entry.GetPrompt()}|{entry.GetResponse()}");
                }
            }

            Console.WriteLine("Journal saved successfully.");
        }

        // Loads journal entries from a file
        public void LoadFromFile()
        {
            Console.Write("Enter filename: ");
            string filename = Console.ReadLine();

            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found.");
                return;
            }

            entries.Clear(); // Clear existing entries before loading

            using (StreamReader reader = new StreamReader(filename))
            {
                reader.ReadLine(); 

                while (!reader.EndOfStream)
                {
                    string entryLine = reader.ReadLine();
                    string[] fields = entryLine.Split('|'); 

                    
                    if (fields.Length < 3)
                    {
                        Console.WriteLine("Error loading entry: " + entryLine);
                        continue;
                    }

                    string date = fields[0];
                    string prompt = fields[1];
                    string response = fields[2];

                    Entry loadedEntry = new Entry(prompt, response, date);
                    entries.Add(loadedEntry);
                }
            }

            Console.WriteLine("Journal loaded successfully.");
        }
    }
}

using System.Collections.Generic;
using System.IO;

namespace DailyJournal
{
    // Represents a single journal entry
    class Entry
    {
        public string _prompt;
        public string _response;
        public string _date;

        // Constructor to initialize entry
        public Entry(string prompt, string response, string date)
        {
            _prompt = prompt;
            _response = response;
            _date = date;
        }

        // Getters for each field
        public string GetPrompt() => _prompt;
        public string GetResponse() => _response;
        public string GetDate() => _date;

        // Formats the entry as a string
        public override string ToString()
        {
            return $"Date: {_date} - Prompt: {_prompt} \n{_response}\n";
        }
    }
}
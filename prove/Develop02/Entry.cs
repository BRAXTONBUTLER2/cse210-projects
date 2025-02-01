using System.Collections.Generic;
using System.IO;

namespace DailyJournal
{
    // one journa entry
    class Entry
    {
        public string _prompt;
        public string _response;
        public string _date;

        // starts or inializes entry
        public Entry(string prompt, string response, string date)
        {
            _prompt = prompt;
            _response = response;
            _date = date;
        }

        
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
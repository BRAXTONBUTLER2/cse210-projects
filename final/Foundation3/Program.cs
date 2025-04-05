class Program
{
    
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Location location1 = new Location("123 Innovation Drive", "Silicon Valley", "CA", "USA");
        Location location2 = new Location("456 Art Lane", "New York", "NY", "USA");
        Location location3 = new Location("789 Park Road", "Los Angeles", "CA", "USA");

        EventDetails seminar = new Seminar(
            "Tech Innovations 2025",
            "A deep dive into the latest breakthroughs in technology.",
            "11/12/2025",
            "10:00 AM",
            location1,
            "Elon Musk",
            500);

        EventDetails gathering = new Gathering(
            "Art & Craft Showcase",
            "Local artists showcasing unique art pieces and handmade goods.",
            "12/05/2025",
            "6:00 PM",
            location2,
            "rsvp@artshowcase.com");

        EventDetails outdoorEvent = new OutdoorEvent(
            "Summer Music Fest",
            "A weekend of live music performances and food trucks.",
            "07/18/2025",
            "1:00 PM",
            location3,
            "Partly cloudy, 82°F");

        List<EventDetails> allEvents = new List<EventDetails> { seminar, gathering, outdoorEvent };

        foreach (EventDetails eventDetail in allEvents)
        {
            Console.WriteLine("---- Basic Info ----");
            Console.WriteLine(eventDetail.DisplayBasicInfo());
            Console.WriteLine("\n---- Full Details ----");
            Console.WriteLine(eventDetail.ShowFullDetails());
            Console.WriteLine("\n---- Brief Info ----");
            Console.WriteLine(eventDetail.ShowBriefInfo());
            Console.WriteLine("\n-----------------------------\n");
        }
    }
}

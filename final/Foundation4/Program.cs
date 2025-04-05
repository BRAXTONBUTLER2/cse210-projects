using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("04/01/2025", 30, 4.5));
        activities.Add(new StationaryBicycles("04/03/2025", 45, 20));
        activities.Add(new Swimming("04/05/2025", 25, 30));

        Console.WriteLine("Exercise Summaries:\n");

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

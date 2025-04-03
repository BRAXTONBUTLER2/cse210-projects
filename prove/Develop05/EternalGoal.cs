public class EternalGoal : Goal
{
    // I exedeed requirnments by gamifying the goals, you can earn points by completing goals         :)//
    private int _recordCount;

    public EternalGoal(string name, string description, int pointsPerCompletion)
        : base(name, description, pointsPerCompletion)
    {
        _recordCount = 0;
    }

    public override void RecordProgress()
    {
        AddPoints(GetPointsWorth()); 
        _recordCount++;
        Console.WriteLine($"Progress logged for '{GetName()}'. You've gained {GetPointsWorth()} points! (Recorded {_recordCount} times)");
    }

    public override string DisplayStatus()
    {
        return $"🔄 {GetName()} - {GetDescription()} ({GetPointsWorth()} Points) (Logged {_recordCount} times)";
    }
}

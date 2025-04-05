public class Seminar : EventDetails
{
    private string _speakerName;
    private int _attendeeLimit;

    public Seminar(string title, string description, string date, string time, Location location, string speaker, int capacity)
        : base(title, description, date, time, location)
    {
        _speakerName = speaker;
        _attendeeLimit = capacity;
    }

    public override string ShowFullDetails()
    {
        return $"{base.DisplayBasicInfo()}\nType: Seminar\nSpeaker: {_speakerName}\nMax Capacity: {_attendeeLimit}";
    }
}

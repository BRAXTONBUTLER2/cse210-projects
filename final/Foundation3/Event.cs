public class EventDetails
{
    private string _eventTitle;
    private string _eventDescription;
    private string _eventDate;
    private string _eventTime;
    private Location _eventLocation;

    public EventDetails(string title, string description, string date, string time, Location location)
    {
        _eventTitle = title;
        _eventDescription = description;
        _eventDate = date;
        _eventTime = time;
        _eventLocation = location;
    }

    public virtual string DisplayBasicInfo()
    {
        return $"Event: {_eventTitle}\nDetails: {_eventDescription}\nWhen: {_eventDate} at {_eventTime}\nLocation: {_eventLocation}";
    }

    public virtual string ShowFullDetails()
    {
        return DisplayBasicInfo();
    }

    public virtual string ShowBriefInfo()
    {
        return $"Event Type: {GetType().Name} | {_eventTitle} | { _eventDate}";
    }
}

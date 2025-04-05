public class Gathering : EventDetails
{
    private string _contactEmail;

    public Gathering(string title, string description, string date, string time, Location location, string email)
        : base(title, description, date, time, location)
    {
        _contactEmail = email;
    }

    public override string ShowFullDetails()
    {
        return $"{base.DisplayBasicInfo()}\nEvent Type: Gathering\nContact: {_contactEmail}";
    }
}

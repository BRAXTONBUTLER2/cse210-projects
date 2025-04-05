public class OutdoorEvent : EventDetails
{
    private string _weatherPrediction;

    public OutdoorEvent(string title, string description, string date, string time, Location location, string weatherForecast)
        : base(title, description, date, time, location)
    {
        _weatherPrediction = weatherForecast;
    }

    public override string ShowFullDetails()
    {
        return $"{DisplayBasicInfo()}\nEvent Type: Outdoor Event\nWeather: {_weatherPrediction}";
    }

   
}

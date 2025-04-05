public class Location
{
    private string _streetAddress;
    private string _cityName;
    private string _stateName;
    private string _countryName;

    public Location(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _cityName = city;
        _stateName = state;
        _countryName = country;
    }

    public override string ToString()
    {
        return $"{_streetAddress}, {_cityName}, {_stateName}, {_countryName}";
    }
}

public class Address
{
    private string _streetName;
    private string _cityName;
    private string _stateName;
    private string _countryName;

    public Address(string street, string city, string state, string country)
    {
        _streetName = street;
        _cityName = city;
        _stateName = state;
        _countryName = country;
    }

    public bool IsLocatedInUSA()
    {
        return _countryName.Trim().ToLower() == "usa";
    }

    public override string ToString()
    {
        return $"{_streetName}\n{_cityName}, {_stateName}\n{_countryName}";
    }
}

public class Address
{
    private readonly string _streetAddress;
    private readonly string _city;
    private readonly string _stateOrProvince;
    private readonly string _country;

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public bool IsUSA()
    {
        return _stateOrProvince.ToLower() == "usa";
    }

    public string GetDisplayText()
    {
        return $"{_streetAddress}\n{_city}, {_stateOrProvince}, {_country}";
    }
}
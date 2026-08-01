using System;

public class Address
{
    private string _streetAddress;

    private string _city;

    private string _stateProvince;

    private string _country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool livesInUSA()
    {
        return _country != null && _country.ToUpper() == "USA";
    }

    public string GetFormattedAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
    }

}
using System;

public class Customer
{
    private string _name;

    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool livesInUSA()
    {
        return _address.livesInUSA();
    }

    public string GetName()
    {
        return _name;
    }

    public string GetFormattedAddress()
    {
        return _address.GetFormattedAddress();
    }



}
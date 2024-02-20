public class Address
{
private string _streetAddress;
private string _city;
private string _state;
private string _country;

public Address(string streetAdress, string city, string state, string country)
{
    _streetAddress = streetAdress;
    _city = city;
    _state = state;
    _country = country;
}

public bool IsinUSA()
{
    if(_country == "USA")
    {
        return true;
    }

    else
    {
        return false;
    }
    
}

public string DisplayAddress()
{
    return $"Street: {_streetAddress} | City: {_city}\nState/Province: {_state} | Country: {_country}";
}


}
public class Address
{

    private string _address;
    private string _city;
    private string _state;
    private string _country;

    public Address(string address, string city, string state, string country)
{
    _address = address;
    _city = city;
    _state = state;
    _country = country;
}
    public string DisplayAddress()
    {
        return $"Street: {_address} | City: {_city} | State/Province: {_state} | Country: {_country}";
    }




























}
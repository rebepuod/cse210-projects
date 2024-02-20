public class Event
{
private string _eventTitle;
private string _description;
private string _date;
private string _time;
private Address _address; 

public Event(string eventTitle, string description, string date, string time, Address address)
{
    _eventTitle = eventTitle;
    _description = description;
    _date = date;
    _time = time;
    _address = address;
}

public string StandarDetails()
{
    return $"Title: {_eventTitle}\nDescription: {_description}\nDate: {_date}\nAddress: \n{_address.DisplayAddress()}";
}

public string GetTitle()
{
    return _eventTitle;
}

public string GetDate()
{
    return _date;
}































}
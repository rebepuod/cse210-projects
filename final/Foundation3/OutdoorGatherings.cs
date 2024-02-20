public class OutdoorGatherings : Event
{

private string _weather;

public OutdoorGatherings(string eventTitle, string description, string date, string time, Address address, string weather) : base(eventTitle, description, date, time, address)
{
    _weather = weather;
}


public string FullDetails()
{
    return $"{StandarDetails()}\nWeather:{_weather}";
}


public string ShortDescription()
{
    return $"Outdoor Gathering Event\nTitle: {GetTitle()}\nDate: {GetDate()}";
}














}
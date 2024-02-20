public class Lectures : Event
{
private string _speakerName;
private int _capacity;

public Lectures(string eventTitle, string description, string date, string time, Address address,string speakerName, int capacity) : base(eventTitle, description, date, time, address)
{
    _speakerName = speakerName;
    _capacity = capacity;
}

public string FullDetails()
{
    return $"{StandarDetails()}\nSpeaker: {_speakerName}\nCapacity: {_capacity}";
}


public string ShortDescription()
{
    return $"Lecture Event\nTitle: {GetTitle()}\nDate: {GetDate()}";
}















}
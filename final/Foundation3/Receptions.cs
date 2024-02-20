public class Receptions : Event
{

private string _email;

public Receptions(string eventTitle, string description, string date, string time, Address address, string email) : base(eventTitle, description, date, time, address)
{
    _email = email;
}


public string FullDetails()
{
    return $"{StandarDetails()}\nEmail: {_email}";
}


public string ShortDescription()
{
    return $"Reception Event\nTitle: {GetTitle()}\nDate: {GetDate()}";
}














}
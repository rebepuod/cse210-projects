// "Object"
// "Object oriented programming"
// "Programming with classes"

// A class is a blueprint
// An object is the thing itself
public class Entry
{

    public string _date;
    public string _promptText;
    public string _entryText;



    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
    }

}
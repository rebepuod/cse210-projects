using System.Formats.Asn1;
using System.Runtime.Serialization;

public class Activity
{
private string _name;
private string _description;
private int _duration;


public Activity()
{
    _name = "";
    _description = "";
    _duration = 12;
}
public void SetName(string name)
{
    _name = name;
}
public void SetDescription(string description)
{
    _description = description;
}
public void SetDuration(int duration)
{
    _duration = duration;
}
public int GetDuration()
{
    return _duration;
}


public void DisplayStartingMessage()
{
    Console.WriteLine($"Welcome to the {_name}.");
    Console.WriteLine();
    Console.WriteLine(_description);
    Console.WriteLine();
    Console.Write("How long, in seconds, you would like for your session?: ");
    string time = Console.ReadLine();
    int newTime = int.Parse(time);
    SetDuration(newTime);
    Console.Clear();
    Console.WriteLine("Get Ready...");
    ShowSpinner(5);
}

public void DisplayEndingMessage()
{
    Console.WriteLine();
    Console.WriteLine("Well Done!");
    ShowSpinner(4);
    Console.WriteLine();
    Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
    ShowSpinner(4);
    Console.Clear();   
}

public void ShowSpinner(int seconds)
{
    List<string> spinner = new List<string>();
    spinner.Add("|");
    spinner.Add("/");
    spinner.Add("-");
    spinner.Add("\\");
    spinner.Add("|");
    spinner.Add("/");
    spinner.Add("-");
    spinner.Add("\\");
    
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(seconds);
    int i = 0;

    while (DateTime.Now < endTime)
    {
        string s = spinner[i];
        Console.Write(s);
        Thread.Sleep(500);
        Console.Write("\b \b");

        i++;

        if (i >= spinner.Count)
        {
            i = 0;
        }
    }

}

public void ShowCountDown(int seconds)
{
    for(int i = seconds; i > 0 ; i--)
    {
    Console.Write($"{i}...");
    Thread.Sleep(1000);
    Console.Write("\b \b");
    }
}

















}
using System.Diagnostics;
using System.Formats.Asn1;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

public class ListingActivity : Activity
{
private int _count;
private List<string> _prompts = new List<string>{
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
};

public ListingActivity()
{
    SetName("Listing Activity");
    SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
}

public void Run()
{
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(GetDuration());
    Console.WriteLine("List as many responses you can to the following prompt: ");
    string prompt = GetRandomPrompt();
    Console.WriteLine($"--- {prompt} ---");
    ShowCountDown(5);
    Console.WriteLine();
    _count = 0;
    while(DateTime.Now <= endTime)
    {
        GetListFromUser();   
        _count ++;  
    }


     Console.WriteLine($"You listed {_count} items!");


}

public string GetRandomPrompt()
{
    Random r1 = new Random(); 
    int index = r1.Next(0, _prompts.Count);
    return _prompts[index];
    }

public List<string> GetListFromUser()
{   
    Console.Write("> ");
    string answers =  Console.ReadLine();
    List<string> userList = new List<string>();
    userList.Add(answers);
   
    return userList;
    }


}
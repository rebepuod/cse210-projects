using System.Diagnostics;

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

}

public void GetRandomPrompt()
{
    // Random r1 = new Random();
    
    // foreach(string a in _prompts)
    // {
    // int index = r1.Next(0, _prompts.Count);
    //  a = _prompts[index];
    // }
}

// public List<string> GetListFromUser()
// {

// }





}
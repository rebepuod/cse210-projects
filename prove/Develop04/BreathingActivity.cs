using System.ComponentModel;

public class BreathingActivity : Activity
{

public BreathingActivity()
{
 SetName("Breathing Activity");
 SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
}

public void Run()
{   DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(GetDuration());
    
    while(DateTime.Now <= endTime)
    
    { 
    Console.WriteLine();
    Console.Write("Breathe in...");

    for (int i = 4; i > 0 ; i--)
    {
    Console.Write(i);
    Thread.Sleep(1000);
    Console.Write("\b \b");
    }

    Console.WriteLine();
    

    Console.Write("Breathe out...");
    for (int i = 4; i > 0 ; i--)
    {
    Console.Write(i);
    Thread.Sleep(1000);
    Console.Write("\b \b");
    
    }
    Console.WriteLine();
    }
}


























}
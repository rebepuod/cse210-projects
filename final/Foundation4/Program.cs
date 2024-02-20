using System;

class Program
{
    static void Main(string[] args)
    {

        Running r1 = new Running("30/01/2024",30, 5.5);

        Cycling c1 = new Cycling("15/02/2024", 20, 10.28);

        Swimming s1 = new Swimming("12/01/2024", 40, 20);

        List<Activity> Activities = new List<Activity>{r1,c1,s1};


        foreach(Activity act in Activities)
        {
            Console.WriteLine(act.GetSummary());
        }








































































       
        
    }
}
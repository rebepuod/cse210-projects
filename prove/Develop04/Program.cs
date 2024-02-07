using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
    
        Activity a1 = new Activity();
        

        BreathingActivity b1 = new BreathingActivity();

        ReflectingActivity r1 = new ReflectingActivity();

        ListingActivity l1 = new ListingActivity();



        // ----------------------------------------------------------- Menu --------------------------------------------------------

        List<string> menu = new List<string>();
        menu.Add("1. Breathing Activity");
        menu.Add("2. Reflecting Activity");
        menu.Add("3. Listing Activity");
        menu.Add("4. Quit");
    
        string user = "";

        while (user != "4")
            {   
            
            Console.WriteLine("Menu options:");
            foreach( string l in menu)
            {
            Console.WriteLine(l);
            }

            Console.Write("Select a choice from the menu: ");
            user = Console.ReadLine();
            Console.Clear();
            
            
            if (user == "1")
            {
                b1.DisplayStartingMessage();
                b1.Run();
                Console.WriteLine();
                b1.DisplayEndingMessage();
            }

            else if (user == "2")
            {
                r1.DisplayStartingMessage();
                r1.Run();
                Console.WriteLine();
                r1.DisplayEndingMessage();
            }

            else if (user == "3")
            {
                l1.DisplayStartingMessage();
                l1.Run();
                Console.WriteLine();
                l1.DisplayEndingMessage();
            }
        }
    }
}
using System;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        DateTime _date = DateTime.Now;
        string dateText = _date.ToShortDateString();
         
        PromptGenerator prompt = new PromptGenerator();
        prompt._prompts.Add("What are 3 things you are gratefull today? ");
        prompt._prompts.Add("Who made you happy today? ");
        prompt._prompts.Add("What did you do for someone else in this day? ");
        prompt._prompts.Add("Who was the most interesting person I interacted with today? ");
        prompt._prompts.Add("what did you do today that makes you proud? ");
        prompt._prompts.Add("What challenge did you overcome today? ");
        

        Entry anEntry = new Entry();
        
        anEntry._date = dateText;
        anEntry._promptText = prompt.GetRandomPrompt();

        Journal theJournal = new Journal();
        
        

        //MENU DISPLAY
        Console.WriteLine("Welcome to the Journal Program!");
       
        string user = "";

       while(user != "5")
       {

        Console.WriteLine("Please select one of the following choices.");

        List<string> options = new List<string>();
        options.Add("1. Write");
        options.Add("2. Display");
        options.Add("3. Load");
        options.Add("4. Save");
        options.Add("5. Quit");
       

        foreach(string option in options)
        {
            Console.WriteLine(option);
        }
        Console.Write("What do you want to do?: ");
        user = Console.ReadLine();



        if (user == "1")
        {
            Console.WriteLine(prompt.GetRandomPrompt());
            anEntry._entryText = Console.ReadLine(); 
            theJournal.AddEntry(anEntry);
        }

        else if (user == "2")
        {
            theJournal.DisplayAll();
        }

        else if (user == "3")
        {
            Console.Write("What is the filename?: ");
            string file = Console.ReadLine();
            theJournal.LoadFromFile(file);                      
        }

        else if (user == "4")
        {
            Console.Write("What is the filename?: ");
            string file = Console.ReadLine();
            theJournal.SaveToFile(file);
        }



       }


        

       

    }
}
using System;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.Arm;

class Program
{
    
    static void Main(string[] args)
    {
       
        Random getRandom = new Random();
        int numberToHide = getRandom.Next(1,4);
       
        Reference r1 = new Reference("Proverbs", 3, 5); 
              
        Scripture s1 = new Scripture(r1, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

       
        bool done = false;
        while (done != true)
        {
            Console.Clear();
            Console.WriteLine(s1.GetDisplayText());           
            Console.Write("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();
            

          
            
            if(input == "quit" || s1.AllWordsHidden())
            {
                done = true;
            }

            else{
                s1.HideRandomWords(numberToHide);
            }
        }
    }
}
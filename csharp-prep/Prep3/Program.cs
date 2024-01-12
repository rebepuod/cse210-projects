using System;

class Program
{
    static void Main(string[] args)
    { 
        
        Console.Write("What is the magic number? ");
        int magicnumber = int.Parse(Console.ReadLine());

        
        int guess = 0;

        while (magicnumber != guess)

        {

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());      

        
            if (magicnumber > guess)
            {
                Console.WriteLine("Higher");
                
            }

            if (magicnumber < guess)
            {
                Console.WriteLine("Lower");
            }

            if (magicnumber == guess)
            {
                Console.WriteLine("You guessed it!");
            }
         
        }
    }    
}
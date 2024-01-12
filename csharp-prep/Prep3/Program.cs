using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    { 
        
        Random randomGenerator = new Random();
        int magicnumber = randomGenerator.Next(1, 100);

        
        Console.Write("What is the magic number? ");
        Console.WriteLine(magicnumber);
        
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
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string askmagicnumber = Console.ReadLine();

        Console.Write("What is your guess? ");
        string askguess = Console.ReadLine();      

        int magicnumber = int.Parse(askmagicnumber);
        int guess = int.Parse(askguess);

       
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
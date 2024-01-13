using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
        Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }  

        DisplayWelcome();
        string userName = PromptUserName();
        int usernumber = PromptUserNumber();

             

        static int SquareNumber(int usernumber)
        {
        int square = usernumber * usernumber;
        return square;
        }

        int square = SquareNumber(usernumber);

        static void DisplayResult(string userName, int square)
        {
            Console.WriteLine($"{userName}, the square of your number is {square}");
        }

        DisplayResult(userName, square);

        


    }
}
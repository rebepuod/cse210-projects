using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the grade percentage? ");
        string userinput =Console.ReadLine();
        int grade = int.Parse(userinput);
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }

        Console.WriteLine(letter);

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations!, You passed the class");
        }
        else 
        {
            Console.WriteLine("You did not passed the class");
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the grade percentage? ");
        string userinput =Console.ReadLine();
        int grade = int.Parse(userinput);

        if (grade >= 90)
        {
            Console.WriteLine("A");
        }

        else if (grade >= 80)
        {
            Console.WriteLine("B");
        }

        else if (grade >= 70)
        {
            Console.WriteLine("C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("D");
        }
        else if (grade < 60)
        {
            Console.WriteLine("F");
        }

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
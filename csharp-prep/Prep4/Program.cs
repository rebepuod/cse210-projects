using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a listo of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();

        int number = 1;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number= int.Parse(Console.ReadLine());
            numbers.Add(number);

        } 
        

        int sum = 0;
        int largest = -100;
        foreach (int t in numbers)
            {
                sum += t;
                if (t > largest)
                {
                    largest = t;
                };
            }
        Console.WriteLine($"The sum is: {sum}");
        float average = ((float)sum) / (numbers.Count-1);

        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}
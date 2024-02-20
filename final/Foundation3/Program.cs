using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("Las Lomitas 552","CABA","Buenos Aires","Argentina");
       
        
        Lectures l1 = new Lectures("'The one' Reading with me","We will read my new book 'The one' and discuss about it", "25/04/2024", "10:00hs", a1,"Nicolas Flakes", 150);
        Console.WriteLine("---------------------Standar Details-----------------------------");
        Console.WriteLine(l1.StandarDetails());
        Console.WriteLine();
        Console.WriteLine("---------------------Full Details--------------------------------");
        Console.WriteLine(l1.FullDetails());
        Console.WriteLine();
        Console.WriteLine("--------------------Short Description----------------------------");
        Console.WriteLine(l1.ShortDescription());

        Address a2 = new Address("Calamar 774", "NY", "New York", "USA");

        Receptions r1 = new Receptions("Our Wedding", "Come spend this special day with us", "15/07/2024", "20:00hs", a2, "abc123@gmail.com");
        Console.WriteLine();
        Console.WriteLine("---------------------Standar Details-----------------------------");
        Console.WriteLine(r1.StandarDetails());
        Console.WriteLine();
        Console.WriteLine("---------------------Full Details--------------------------------");
        Console.WriteLine(r1.FullDetails());
        Console.WriteLine();
        Console.WriteLine("--------------------Short Description----------------------------");
        Console.WriteLine(r1.ShortDescription());

        Address a3 = new Address("Paloma 123", "Milan", "Milan", "Italy");

        OutdoorGatherings o1 = new OutdoorGatherings("Picnic day", "Come enjoy with us an amazing picknick day!", "30/06/2024", "16:00hs", a3, "Sunny");
        Console.WriteLine();
        Console.WriteLine("---------------------Standar Details-----------------------------");
        Console.WriteLine(o1.StandarDetails());
        Console.WriteLine();
        Console.WriteLine("---------------------Full Details--------------------------------");
        Console.WriteLine(o1.FullDetails());
        Console.WriteLine();
        Console.WriteLine("--------------------Short Description----------------------------");
        Console.WriteLine(o1.ShortDescription());





























    }
}
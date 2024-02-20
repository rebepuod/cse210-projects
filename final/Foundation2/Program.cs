using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Product p1 = new Product("Salt", "ABC123", 1.5, 1);
        Product p2 = new Product("Couch","ABC456", 250, 2);
        Product p3 = new Product("Glass","ABC789", 15, 3);

        List<Product> products = new List<Product>{p1, p2, p3};

        Address a1 = new Address("Mystreet 43", "CABA", "Buenos Aires", "Argentina");
        Customer c1 = new Customer("Ricardo Gonzales", a1);
        Order o1 = new Order(products , c1);
        
        

        Product p4 = new Product("Table", "A1B2C3", 150, 1);
        Product p5 = new Product("Chair","A2B2C2", 50, 6);
        Product p6 = new Product("Jar","A3B278", 15, 2);

        List<Product> products1 = new List<Product>{p4, p5, p6};
        
        Address a2 = new Address("Mystreet 43", "Los Angeles", "California", "USA");
        Customer c2 = new Customer("Lucca Montenegro", a2);
        Order o2 = new Order(products1 , c2);

        //ORDER 1
        Console.WriteLine(o1.DisplayPackingLabel());
        Console.WriteLine(o1.DisplayShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost = ${o1.CalculateTotalOrderCost()}");

        Console.WriteLine();
        //ORDER 2

        Console.WriteLine(o2.DisplayPackingLabel());
        Console.WriteLine(o2.DisplayShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost = ${o2.CalculateTotalOrderCost()}");































    }
}
using System.ComponentModel;
using System.Data.SqlTypes;

public class Order
{
private List<Product> _products = new List<Product>();
private Customer _custumer;

public Order(List<Product> products, Customer customer)
{
    _products = products;
    _custumer = customer;
}

public double CalculateTotalOrderCost()
{
    double totalPrice = 0;
    foreach(Product p in _products)
    {
        double sum = p.CalculateTotalProductCost();
        totalPrice += sum;
    }
    double shippCost = totalPrice + CalculateShippingCost();
    return shippCost;
}

public string DisplayPackingLabel()
{
    string packingLabel = "Packing Label: \n";
    foreach(Product p in _products)
    {
       packingLabel += $"{p.GetName()} - Id: {p.GetId()}\n";
    }      
    return packingLabel;
}


public string DisplayShippingLabel()
{   
    string shippingLabel = "Shipping Label: \n";
    shippingLabel += $"Name: {_custumer.GetName()} - Adress:\n{_custumer.DisplayAddress()}";

    return shippingLabel;
}

public double CalculateShippingCost()
{
    double shippCost = 0;
    if(_custumer.LiveinUSA() == true)
    {
       shippCost = 5;
    }
    

    else if(_custumer.LiveinUSA() == false)
    {
        shippCost = 35;
    }

    return shippCost;
}





























}
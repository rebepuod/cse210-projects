public class Customer
{
private string _name;
private Address _address;



public Customer(string name, Address adress)
{
    _name = name;
    _address = adress;
}

public bool LiveinUSA()
{
    return _address.IsinUSA();
}

public string GetName()
{
    return _name;
}

public string DisplayAddress()
{
    string dAdress = _address.DisplayAddress();
    return dAdress;
}























}
public class Square : Shape
{

private double _side;

public Square(string color, double side) 
{
    SetColor(color);
}

public double GetArea()
{
    return _side * _side;
}


























}
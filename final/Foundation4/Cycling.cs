public class Cycling : Activity
{
private double _speed;

public Cycling(string date, double lenght, double speed) : base(date, lenght)
{
    _speed = speed;
    _name = "Cycling";
}

   public override double CalculateDistance()
    {
        return _speed * _lenght / 60;
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }

    public override double CalculatePace()
    {
        return 60 / _speed;
    }

   




















}
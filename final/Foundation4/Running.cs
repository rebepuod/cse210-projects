public class Running : Activity
{

private double _distance;


public Running(string date, double lenght, double distance) : base(date, lenght)
{
    _distance = distance;
    _name = "Running";
    
}

    public override double CalculateDistance()
    {
        return _distance;
    }

    public override double CalculateSpeed()
    {
        return _distance/ _lenght * 60;
    }

    public override double CalculatePace()
    {
        return _lenght / _distance;
    }

    






















}
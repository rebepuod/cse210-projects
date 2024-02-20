public class Swimming : Activity
{
private int _numberOfLaps;


public Swimming(string date, double lenght, int numberOfLaps) : base(date, lenght)
{
    _numberOfLaps = numberOfLaps;
    _name = "Swimming";
}


public override double CalculateDistance()
    {
        return _numberOfLaps * 50 / 1000;
    }

    public override double CalculateSpeed()
    {
        return CalculateDistance() / _lenght * 60;
    }

    public override double CalculatePace()
    {
        return _lenght / CalculateDistance();
    }

































}
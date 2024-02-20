public class Activity
{
protected string _date;
protected double _lenght;
protected string _name;

public Activity(string date, double lenght)
{
    _date = date;
    _lenght = lenght;  
}

public virtual double CalculateDistance()
{
    return 0;
}
public virtual double CalculateSpeed()
{
    return 0;
}

public virtual double CalculatePace()
{
    return 0;
}

public string GetSummary()
{
    return $"* {_date} {_name}({_lenght}min) - Distance {Math.Round(CalculateDistance(),2)} Km, Speed {CalculateSpeed()} mph, Pace: {Math.Round(CalculatePace(),2)} min per Km";
}




















}
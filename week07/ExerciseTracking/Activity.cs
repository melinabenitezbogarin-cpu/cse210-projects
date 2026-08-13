using System;

public abstract class Activity
{
    private int _minutes;
    private string _date;

    public Activity(string date, int minutes)
    {
        _minutes = minutes;
        _date = date;
    }

    public string GetDate()
    {
        return _date;
    }


    public int GetMinutes()
    {
        return _minutes;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_minutes} min) - Distance: {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
    }

}
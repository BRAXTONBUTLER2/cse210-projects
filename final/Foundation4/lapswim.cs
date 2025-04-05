using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0; // 50 meters per lap
    }

    public override double GetSpeed()
    {
        return GetDistance() / GetDuration() * 60;
    }

    public override double GetPace()
    {
        return GetDuration() / GetDistance();
    }
}

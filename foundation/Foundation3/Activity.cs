using System;

public abstract class Activity
{
    // Common properties for all activities
    private DateTime _date;
    private int _duration; // in minutes

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    // Properties for encapsulation
    public DateTime Date => _date;
    public int Duration => _duration;

    // Abstract methods to calculate distance, speed, and pace
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Summary method to get the summary of the activity
    public virtual string GetSummary()
    {
        return $"{Date:dd MMM yyyy} {GetType().Name} ({Duration} min)";
    }
}

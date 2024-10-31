public class Running : Activity
{
    private double _distance; // in miles

    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed() => (GetDistance() / Duration) * 60; // in mph

    public override double GetPace() => Duration / GetDistance(); // in min per mile

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace():0.00} min per mile";
    }
}

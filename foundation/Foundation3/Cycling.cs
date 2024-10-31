public class Cycling : Activity
{
    private double _speed; // in mph

    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance() => (GetSpeed() * Duration) / 60; // in miles

    public override double GetSpeed() => _speed; // mph

    public override double GetPace() => 60 / GetSpeed(); // in min per mile

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace():0.00} min per mile";
    }
}

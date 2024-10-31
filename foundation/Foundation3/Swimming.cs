public class Swimming : Activity
{
    private int _laps; // number of laps

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance() => (_laps * 50) / 1000.0; // in kilometers

    public override double GetSpeed() => (GetDistance() / Duration) * 60; // in kph

    public override double GetPace() => Duration / GetDistance(); // in min per km

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance():0.00} km, Speed: {GetSpeed():0.00} kph, Pace: {GetPace():0.00} min per km";
    }
}

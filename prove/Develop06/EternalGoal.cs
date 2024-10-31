public class EternalGoal : Goal
{
    private int _pointsPerEvent;
    private string _color; // Field for color

    public EternalGoal(string color, int pointsPerEvent)
    {
        _color = color; // Set the color
        _pointsPerEvent = pointsPerEvent;
    }

    public override void RecordEvent()
    {
        _score += _pointsPerEvent; // Increment score by points per event each time it's recorded
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()}, Color: {_color}, (Eternal Goal)";
    }
}

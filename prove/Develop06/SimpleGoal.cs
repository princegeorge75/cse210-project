public class SimpleGoal : Goal
{
    private int _points;
    private bool _isComplete;
    private string _color; // Field for color

    public SimpleGoal(string color, int points)
    {
        _color = color; // Set the color
        _points = points;
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            _score += _points;
        }
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()}, Color: {_color}, Completed: {_isComplete}";
    }
}

public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;
    private string _color; // Field for color

    public ChecklistGoal(string color, int targetCount, int bonusPoints)
    {
        _color = color; // Set the color
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            _score += 50; // Add points for each recorded event

            if (_currentCount == _targetCount)
            {
                _score += _bonusPoints; // Add bonus points when target is reached
            }
        }
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()}, Color: {_color}, Completed: {_currentCount}/{_targetCount}";
    }
}

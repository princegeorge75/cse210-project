using System;

public abstract class Goal
{
    protected int _score;

    protected Goal()
    {
        _score = 0;
    }

    public abstract void RecordEvent(); // Abstract method to be implemented by derived classes

    public int GetScore() => _score;

    public virtual string GetDetailsString()
    {
        return $"Goal Type: {GetType().Name}, Score: {_score}";
    }
}

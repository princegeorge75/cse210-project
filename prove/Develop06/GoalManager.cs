using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _totalPoints;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalPoints = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordGoalEvent(string goalName)
    {
        foreach (var goal in _goals)
        {
            if (goal.GetType().Name == goalName)
            {
                goal.RecordEvent();
                _totalPoints += goal.GetScore();
                break;
            }
        }
    }

    public void DisplayGoals()
    {
        foreach (var goal in _goals)
        {
            System.Console.WriteLine(goal.GetDetailsString());
        }
        System.Console.WriteLine($"Total Points: {_totalPoints}");
    }

    public void SaveGoals(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetDetailsString());
            }
            writer.WriteLine($"Total Points: {_totalPoints}");
        }
    }

    public void LoadGoals(string filePath)
    {
        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Split the line based on the delimiter
                    string[] parts = line.Split(';');

                    if (parts.Length == 4) // SimpleGoal
                    {
                        string color = parts[1];
                        int points = int.Parse(parts[2]);
                        bool completed = bool.Parse(parts[3]);
                        var goal = new SimpleGoal(color, points);
                        if (completed)
                        {
                            goal.RecordEvent(); // Mark it as complete
                        }
                        _goals.Add(goal);
                    }
                    else if (parts.Length == 3) // EternalGoal
                    {
                        string color = parts[1];
                        int pointsPerEvent = int.Parse(parts[2]);
                        var goal = new EternalGoal(color, pointsPerEvent);
                        _goals.Add(goal);
                    }
                    else if (parts.Length == 5) // ChecklistGoal
                    {
                        string color = parts[1];
                        int targetCount = int.Parse(parts[2]);
                        int bonusPoints = int.Parse(parts[3]);
                        int currentCount = int.Parse(parts[4]);
                        var goal = new ChecklistGoal(color, targetCount, bonusPoints);
                        // Set the current count (you may want to implement a setter for this)
                        for (int i = 0; i < currentCount; i++)
                        {
                            goal.RecordEvent();
                        }
                        _goals.Add(goal);
                    }
                }
            }
        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Add Simple Goal");
            Console.WriteLine("2. Add Eternal Goal");
            Console.WriteLine("3. Add Checklist Goal");
            Console.WriteLine("4. Record Goal Event");
            Console.WriteLine("5. Display Goals");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter goal color: ");
                    string color = Console.ReadLine();
                    Console.Write("Enter points for this goal: ");
                    int points;
                    while (!int.TryParse(Console.ReadLine(), out points))
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                    goalManager.AddGoal(new SimpleGoal(color, points));
                    Console.WriteLine("Simple Goal added!");
                    break;

                case "2":
                    Console.Write("Enter goal color: ");
                    color = Console.ReadLine();
                    Console.Write("Enter points for each event: ");
                    int pointsPerEvent;
                    while (!int.TryParse(Console.ReadLine(), out pointsPerEvent))
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                    goalManager.AddGoal(new EternalGoal(color, pointsPerEvent));
                    Console.WriteLine("Eternal Goal added!");
                    break;

                case "3":
                    Console.Write("Enter goal color: ");
                    color = Console.ReadLine();
                    Console.Write("Enter target count: ");
                    int targetCount;
                    while (!int.TryParse(Console.ReadLine(), out targetCount))
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                    Console.Write("Enter bonus points: ");
                    int bonusPoints;
                    while (!int.TryParse(Console.ReadLine(), out bonusPoints))
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                    goalManager.AddGoal(new ChecklistGoal(color, targetCount, bonusPoints));
                    Console.WriteLine("Checklist Goal added!");
                    break;

                case "4":
                    Console.Write("Enter the goal type to record (SimpleGoal, EternalGoal, ChecklistGoal): ");
                    string goalType = Console.ReadLine();
                    goalManager.RecordGoalEvent(goalType);
                    Console.WriteLine($"Recorded event for {goalType}.");
                    break;

                case "5":
                    goalManager.DisplayGoals();
                    break;

                case "6":
                    goalManager.SaveGoals("goals.txt");
                    Console.WriteLine("Goals saved to goals.txt.");
                    break;

                case "7":
                    goalManager.LoadGoals("goals.txt");
                    Console.WriteLine("Goals loaded from goals.txt.");
                    goalManager.DisplayGoals(); // Display loaded goals immediately
                    break;

                case "8":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}

/* 
    Exceeded Requirements:
    - Added a scoring system that rewards users with points for completing goals.
    - Implemented saving and loading goals to and from a text file.
    - Included the ability to check for bonus points in ChecklistGoals.
    - Designed the user interface to guide users through adding and managing goals interactively.
*/

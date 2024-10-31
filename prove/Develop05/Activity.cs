public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity!");
        Console.WriteLine($"Description: {_description}");
        Console.Write("How long (in seconds) do you want to engage in this activity? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3); // Show spinner for preparation
    }

    public void DisplayEndingMessage()
    {
        ShowSpinner(1); // Show a short spinner before finishing message
        Console.WriteLine($"Congratulations on completing the {_name} activity for {_duration} seconds!");
        Console.WriteLine("We hope you feel refreshed and empowered!");
        ShowSpinner(2); // Show spinner for finishing
    }

    public void ShowSpinner(int seconds)
    {
        Console.Write("Loading");
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("."); // Show spinner effect
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    
    public int GetDuration()
    {
        return _duration;
    }

    // Exceed requirement: log activity completion time to a simple text file
    public void LogCompletion()
    {
        string logMessage = $"{_name} activity completed at {DateTime.Now}";
        System.IO.File.AppendAllText("activity_log.txt", logMessage + Environment.NewLine);
        Console.WriteLine("Activity completion logged!");
    }

    public abstract void Run(); // Abstract method to be implemented by derived classes
}

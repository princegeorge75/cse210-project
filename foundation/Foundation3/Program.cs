using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold activities
        List<Activity> activities = new List<Activity>();

        // Create activities
        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 3.0));
        activities.Add(new Cycling(new DateTime(2022, 11, 4), 45, 15.0));
        activities.Add(new Swimming(new DateTime(2022, 11, 5), 60, 20));

        // Iterate through the list and display summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
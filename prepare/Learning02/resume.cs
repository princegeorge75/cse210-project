using System;

public class Resume
{
    // Member variables
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // Display method to show resume details
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.Write("Jobs: ");

        // Iterate through each job and display its details
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}

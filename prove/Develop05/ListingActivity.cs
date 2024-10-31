public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> _userList = new List<string>();

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can.")
    {
    }

    public override void Run() // Implementing the abstract method
    {
        DisplayStartingMessage();
        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        ShowSpinner(3);

        int remainingTime = GetDuration();
        while (remainingTime > 0)
        {
            Console.WriteLine("Press Enter when you are ready to enter an item:");
            Console.ReadKey(true); // Wait for the user to press a key
            Console.Write("Enter an item: ");
            _userList.Add(Console.ReadLine());
            remainingTime -= 3; // Reduce remaining time
        }

        Console.WriteLine($"You listed {_userList.Count} items!");
        DisplayEndingMessage();
        LogCompletion();
    }
}

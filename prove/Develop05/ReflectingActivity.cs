public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?"
    };

    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
    }

    public override void Run() // Implementing the abstract method
    {
        DisplayStartingMessage();
        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        
        Console.WriteLine("Press Enter when you are ready to think about your response...");
        Console.ReadKey(true); // Wait for the user to press a key

        int remainingTime = GetDuration();
        while (remainingTime > 0)
        {
            Console.WriteLine(_questions[rand.Next(_questions.Count)]);
            ShowSpinner(3); // Show spinner during thinking time
            remainingTime -= 3; // Reduce remaining time
        }
        DisplayEndingMessage();
        LogCompletion();
    }
}

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by guiding you through slow breathing exercises.")
    {
    }

    public override void Run() // Implementing the abstract method
    {
        DisplayStartingMessage();
        int remainingTime = GetDuration();
        while (remainingTime > 0)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
            remainingTime -= 6; // Reduce remaining time by the duration of in and out
        }
        DisplayEndingMessage();
        LogCompletion();
    }
}

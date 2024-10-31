using System;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random(); // Create a single Random instance

        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            int choice;

            // Input validation
            if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid selection. Please choose a number between 1 and 4.");
                continue;
            }

            if (choice == 4) break;

            Activity activity = null;
            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity();
                    break;
                case 2:
                    activity = new ReflectingActivity();
                    break;
                case 3:
                    activity = new ListingActivity();
                    break;
            }

            if (activity != null)
            {
                activity.Run();
                Console.WriteLine();
            }
        }
    }
}
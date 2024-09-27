using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        // Create a list to store the numbers
        List<int> numbers = new List<int>();

        // Prompt the user to enter numbers
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -1;  // Initialize with a value that won't stop the loop

        // Keep asking for numbers until the user enters 0
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            // Don't add 0 to the list
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        // Compute the sum, average, and maximum
        int sum = numbers.Sum();  // Calculate the sum
        double average = (double)sum / numbers.Count;  // Calculate the average
        int max = numbers.Max();  // Find the maximum value

        // Output the results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        // Stretch challenge: Find the smallest positive number
        int smallestPositive = numbers.Where(n => n > 0).Min();
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        // Stretch challenge: Sort the list and display the sorted numbers
        numbers.Sort();  // Sort the list
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
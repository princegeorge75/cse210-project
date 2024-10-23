using System;

class Program
{
    static void Main(string[] args)
    {
       // Create a scripture reference
       Reference reference = new Reference("Jacob", 1, 19);

       // Create the scripture text
       string text = "And we did magnify our office unto the Lord, taking upon us the responsibility, answering the sins of the people upon our own heads if we did not teach them the word of God with all diligence; wherefore, by laboring with our might their blood might not come upon our garments; otherwise their blood would come upon our garments, and we would not be found spotless at the last day.";

       // Create the scripture object
       Scripture scripture = new Scripture(reference, text);

       //Main loop the words and display the scripture
       while (!scripture.GetDisplayText());
       {
        Console.Clear(); //clear the console

        //Display the current state of the scripture
       Console.WriteLine(scripture.GetDisplayText());

       //Prompt the user
       Console.WriteLine("\nPress enter key to hide more words or type 'quit' to exit the program.");
       string input = Console.ReadLine();

       //If the user types 'quit', exit the program
       if (input.ToLower() == "quit")
       {
        break;
       }

       //Hide a few random words
       scripture.HideRandomWords(3);
       }

        Console.WriteLine("All words are hidden. Goodbye!");
       
    }
}
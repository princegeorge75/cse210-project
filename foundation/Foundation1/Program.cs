using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a few video objects
        Video video1 = new Video("Learn C# in 10 Minutes", "Tech Guru", 600);
        Video video2 = new Video("Best Coding Practices", "Code Master", 720);
        Video video3 = new Video("Understanding OOP Concepts", "Dev Pro", 540);

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "This was very helpful, thanks!"));
        video1.AddComment(new Comment("Bob", "Great explanation, I learned a lot."));
        video1.AddComment(new Comment("Charlie", "Please make more videos on C#!"));

        // Add comments to video2
        video2.AddComment(new Comment("Dave", "This is exactly what I needed."));
        video2.AddComment(new Comment("Eve", "Very informative, thank you!"));

        // Add comments to video3
        video3.AddComment(new Comment("Frank", "I finally understand OOP now!"));

        // Put the videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display the information for each video
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine();  // Print a blank line between videos for clarity
        }
    }
}
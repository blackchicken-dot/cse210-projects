using System;
using System.Collections.Generic;

public class ListingActivity : MindfulnessActivity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt a sense of peace recently?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() 
        : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Run()
    {
        StartMessage();
        Random rand = new Random();
        Console.WriteLine(prompts[rand.Next(prompts.Count)]);
        Pause(3);

        int itemCount = 0;
        int timeElapsed = 0;
        while (timeElapsed < duration)
        {
            Console.Write("Enter an item: ");
            Console.ReadLine();
            itemCount++;
            timeElapsed += 5; // Assume 5 seconds per item input for simplicity
        }

        Console.WriteLine($"You listed {itemCount} items.");
        EndMessage();
    }
}

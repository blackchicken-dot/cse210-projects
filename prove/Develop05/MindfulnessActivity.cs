using System;
using System.Threading;

public class MindfulnessActivity
{
    protected string activityName;
    protected string activityDescription;
    protected int duration;

    public MindfulnessActivity(string name, string description)
    {
        activityName = name;
        activityDescription = description;
    }

    public void StartMessage()
    {
        Console.WriteLine($"Welcome to the {activityName}.");
        Console.WriteLine(activityDescription);
        Console.Write("Enter the duration of the activity (in seconds): ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Pause(3);
    }

    public void EndMessage()
    {
        Console.WriteLine($"Good job! You have completed the {activityName}.");
        Console.WriteLine($"You spent {duration} seconds on this activity.");
        Pause(3);
    }

    protected void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000); // Pause for 1 second
        }
        Console.WriteLine();
    }
}

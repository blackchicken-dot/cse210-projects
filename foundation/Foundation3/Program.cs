using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of each activity
        Running running = new Running(new DateTime(2024, 10, 28), 30, 3.0); // 3 miles in 30 minutes
        Cycling cycling = new Cycling(new DateTime(2024, 10, 28), 45, 15.0); // 15 mph for 45 minutes
        Swimming swimming = new Swimming(new DateTime(2024, 10, 28), 20, 30); // 30 laps in 20 minutes

        // Add all activities to a list
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        // Iterate through the list and display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
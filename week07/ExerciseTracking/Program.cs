using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running run = new Running("13 Aug 2026", 30, 4.8);
        Cycling cycle = new Cycling("13 Aug 2026", 30, 9.7);
        Swimming swim = new Swimming("13 Aug 2026", 30, 40);

        activities.Add(run);
        activities.Add(cycle);
        activities.Add(swim);

        Console.WriteLine("The fitness center Activity");
        Console.WriteLine();

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
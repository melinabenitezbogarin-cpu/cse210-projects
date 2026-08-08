using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing",
        "This activity will help you relax by focusing on your breathing.", 0)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);

            Console.WriteLine("Breathe out...");
            ShowCountdown(6);
        }

        DisplayEndingMessage();
    }
}
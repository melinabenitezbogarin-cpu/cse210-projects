using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private readonly List<string> _prompts;
    private readonly List<string> _questions;

    public ReflectingActivity()
        : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.", 0)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "What did you learn about yourself through this experience?",
            "How did this experience affect others?",
            "How can you apply this strength in your life?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt:");
        GetRandomPrompt();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You need to start: ");
        ShowCountdown(5);

        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            GetRandomQuestion();
            ShowSpinner(5);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }

    private void GetRandomPrompt()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
    }

    private void GetRandomQuestion()
    {
        Random random = new Random();
        string question = _questions[random.Next(_questions.Count)];
        Console.WriteLine(question);
    }


}
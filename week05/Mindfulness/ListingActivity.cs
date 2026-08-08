using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
        : base("Listing Activity", "This activity will help you reflect on things you can list.", 0)
    {
        _prompts = new List<string>
        {
            "What are some things you are grateful for?",
            "What are some ways you can help others?",
            "What are some goals you have for the future?",
            "Who changed your day today?",
            "What did you learn about yourself today?",
            "What makes you happy?",
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many answers as you can to the following prompt:");
        GetRandomPrompt();

        Console.WriteLine("You need to start: ");
        ShowCountdown(5);
        Console.WriteLine();

        List<string> userItems = GetListFromUser();
        _count = userItems.Count;

        Console.WriteLine($"You listed {_count} items.");

        DisplayEndingMessage();
    }
        

    private void GetRandomPrompt()
    {
        _count = 0;
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
    }

    private List<string> GetListFromUser()
    {
        List<string> userItems = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                userItems.Add(input);
            }
        }

        return userItems;
    }
}
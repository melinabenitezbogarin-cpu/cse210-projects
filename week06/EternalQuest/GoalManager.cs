using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;

    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6.Quit");
            Console.Write("Select a choice from the menu: ");

            string input = Console.ReadLine();
            Console.WriteLine();

            switch (input)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalsDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");  
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].ShortName}");
        }
    }

    public void ListGoalsDetails()
    {
        Console.WriteLine("Goal Details:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].Description}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Types of Goals: ");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        string choice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid choice. Goal not created.");
                break;
        }

    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available to record an event.");
            return;
        }

        Console.WriteLine("The goals are: ");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");

        if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= _goals.Count)
        {
            Goal selectedGoal = _goals[choice - 1];

            if (selectedGoal.IsComplete())
            {
                Console.WriteLine("This goal is already complete.");
                return;
            }

            int pointsEarned = selectedGoal.RecordEvent();
            _score += pointsEarned;

            Console.WriteLine($"Congratulations! You have earned {pointsEarned} points.");
            Console.WriteLine($"Now you have {_score} points.");

        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
          
    }

    public void SaveGoals()
    {
        Console.Write("Enter the filename to save the goals: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score); 

            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        if (lines.Length == 0) return;

        _goals.Clear();

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            if (string.IsNullOrWhiteSpace(line)) continue;

            string[] parts = lines[i].Split(':');
            string goalType = parts[0];
            string[] details = parts[1].Split('|');

            switch (goalType)
            {
                case "SimpleGoal":
                    string sName = details[0];
                    string sDescription = details[1];
                    int sPoints = int.Parse(details[2]);
                    bool isComplete = bool.Parse(parts[3]);

                    _goals.Add(new SimpleGoal(sName, sDescription, sPoints, isComplete));
                    break;

                case "EternalGoal":
                    string eName = details[0];
                    string eDescription = details[1];
                    int ePoints = int.Parse(details[2]);

                    _goals.Add(new EternalGoal(eName, eDescription, ePoints));
                    break;

                case "ChecklistGoal":
                    string cName = details[0];
                    string cDescription = details[1];
                    int cPoints = int.Parse(details[2]);
                    int cBonus = int.Parse(details[3]);
                    int cTarget = int.Parse(details[4]);
                    int cAmount = int.Parse(details[5]);

                    _goals.Add(new ChecklistGoal(cName, cDescription, cPoints, cTarget, cBonus));
                    break;
            }
        }

         Console.WriteLine("Goals successfully loaded!");
    }
    

    
}
using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void Display()
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Add a picture");
        Console.WriteLine("6. Quit");
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The Journal is empty. Please add an entry first.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
        Console.WriteLine("These are all of your Journal Entries.");
    }
    
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._prompt},{entry._entry},{entry._imagePath}");
            }
        }
        Console.WriteLine("Journal entries safely saved.");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found. Please check the filename and try again.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            if (parts.Length >= 3)
            {
                Entry entry = new Entry();
                entry._date = parts[0];
                entry._prompt = parts[1];
                entry._entry = parts[2];
                entry._imagePath = parts.Length > 3 ? parts[3] : "";
                _entries.Add(entry);
            }
        }
        Console.WriteLine("Journal loaded.");
    }
}
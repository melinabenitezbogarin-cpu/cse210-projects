// I add an option(the option 5) to add a picture to the journal. The user can enter the path to the image file, and it will be saved in the journal entry. 
// The image path is also saved to the file when saving the journal entries. When loading from a file, the image path is also loaded if it exists.
using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        List<string> prompts = new List<string>
        {
           "What did you learn from today?",
           "What was the most interesting thing about work/school today?",
           "What was a special thing that someone or our Heavenly Father made for you today?",
           "If you have to choose one thing to remember from today, what would it be?",
           "What was something you were grateful for today?",
           "What goal did you accomplish today?"
        };

        Random randomGenerator = new Random();
        string userChoice = "";

        while (userChoice != "6")
        {

            journal.Display();

            Console.Write("What would you like to do? ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {

                int randomIndex = randomGenerator.Next(prompts.Count);
                string userPrompt = prompts[randomIndex];

                Console.WriteLine($"Prompt: {userPrompt}");
                Console.Write("> ");
                string userEntry = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                Entry newEntry = new Entry();
                newEntry._date = dateText;
                newEntry._prompt = userPrompt;
                newEntry._entry = userEntry;
                newEntry._imagePath = "";

                journal.AddEntry(newEntry);
            }

            else if (userChoice == "2")
            {
                Console.WriteLine("Journal Entries:");

                journal.DisplayAll();
                
            }

            else if (userChoice == "3")
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();

                journal.LoadFromFile(filename);;
            }

            else if (userChoice == "4")
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);
            }

            else if (userChoice == "5")
            {

                Console.WriteLine("Please enter the path to your image file:");
                Console.Write("Image Path:");
                string userPicture = Console.ReadLine().Trim('"', ' ');

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                Entry newEntry = new Entry();
                newEntry._date = dateText;
                newEntry._imagePath = userPicture;

                journal.AddEntry(newEntry);
                Console.WriteLine("Your entry with the picture has been added to the journal.");
            }

            else if (userChoice == "6")
            {
                Console.WriteLine("Thank you for writing in your journal,see you tomorrow!");
            }

            else
            {
                Console.WriteLine("Invalid choice. Please try again and write a number.");
            }
        }
    
    }
}   

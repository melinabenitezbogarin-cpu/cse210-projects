using System;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "";

        while (userChoice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;
                case "4":
                    Console.WriteLine("Happy to have you in the Mindfulness Activities program. See you next time!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Choose a valid one!.");
                    break;
            }

    
        }
   }
}
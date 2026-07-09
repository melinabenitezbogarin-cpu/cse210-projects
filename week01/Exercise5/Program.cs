using System;

class Program
{
    static void Main(string[] args)
    {
        {
            DisplayWelcomeMessage();

            string userName = DisplayUserName();
            int userNumber = DisplayFavoriteNumber();

            int squaredNumber = SquareNumber(userNumber);

            DisplayResult(userName, squaredNumber);
        }

        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string DisplayUserName()
        {
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
        }

        static int DisplayFavoriteNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
    }
}
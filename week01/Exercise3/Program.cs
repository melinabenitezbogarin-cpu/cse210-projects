using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Welcome to guess the number game! What is the magic number? ");
        int guessNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);

        int guess = -1;

        while (guess != guessNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guessNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNumber < guess)
            {
                 Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Congrats,you guessed it!");
            }
        }

    }
}  

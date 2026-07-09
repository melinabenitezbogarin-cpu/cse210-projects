using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int input = -1;
        while (input != 0)
        {
            Console.Write("Enter a number(0 to finish): ");
            
            string userInput = Console.ReadLine();

            input = int.Parse(userInput);
            
            if (input != 0)
            {
                numbers.Add(input);
            }
        }
        int sum = 0;

        foreach (int n in numbers)
        {
            sum += n;
        }
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {(float)sum / numbers.Count}");
        Console.WriteLine($"The largest number is {numbers.Max()}");
    }
}
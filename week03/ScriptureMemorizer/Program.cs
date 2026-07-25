using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Matt", 28, 18, 19);
        string text ="And Jesus came and spake unto them, saying, All power is given unto me in heaven and in earth.Go ye therefore, and teach all nations, baptizing them in the name of the Father, and of the Son, and of the Holy Ghost.";
        Scripture scripture = new Scripture(reference, text);

        while(true)
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsAllHidden())
            {
                break;
            }

            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();

            if (input.ToLower()== "quit")
            {
                break;
            }

            scripture.HideVerseWords(3);

        }
    }
}
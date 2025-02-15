using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("Doctrine and Covenants", 122, 8, "The Son of Man hath descended below them all. Art thou greater than he?");

        Console.Clear();
        scripture.Display();
        Console.WriteLine("\nPress enter to continue or type 'quit' to exit.");
        
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            Environment.Exit(0);
        
            else if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                scripture.HideRandomWord();
                Console.Clear();
                scripture.Display();
                Console.WriteLine("\nPress enter to continue or type 'quit' to exit.");
            }
            else
            {
                Console.WriteLine("Invalid input. Press enter to continue or type 'quit' to exit.");
            }
        }


    }
}
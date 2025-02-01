using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        bool isRunning = true;

        Journal journal = new Journal();
        while (isRunning){

            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Add an entry");
            Console.WriteLine("2. Display an entry");
            Console.WriteLine("3. Load a Journal");
            Console.WriteLine("4. Save a Journal");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            string userChoice = Console.ReadLine();
        
            switch (userChoice)
            {
            case "1":
                journal.AddEntry();
                break;

            case "2":
                journal.DisplayJournal();
                break;

            case "3":
                journal.LoadJournal();
                break;
        
            case "4":
                journal.SaveJournal();
                break;

            case "5":
                Console.WriteLine("Goodbye!");
                isRunning = false;
                break;
        
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
            }
        }
    }
}
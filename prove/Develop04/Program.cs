using System;
using System.Reflection.Metadata;

class Program
{
    private static string userChoice;
    static void Main(string[] args)
    {
        
        while (userChoice != "4")
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program!");

            Console.WriteLine("1: Breathing Activity");
            Console.WriteLine("2: Reflection Activity");
            Console.WriteLine("3: Listing Activity");
            Console.WriteLine("4: Graditude Activity");
            Console.WriteLine("5: Quit");

            Console.Write("Choose your activity: ");
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    Breathing breathing = new Breathing();
                    breathing.DoActivity();
                    break;
                case "2":
                    Reflection reflection = new Reflection();
                    reflection.DisplayPrompt();
                    reflection.AnswerQuestions();
                    break;
                case "3":
                    Listing listing = new Listing();
                    listing.DoActivity();
                    break;
                case "4":
                    Graditude graditude = new Graditude();
                    graditude.ListGraditude();
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
                    break;
                case "default":
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}   
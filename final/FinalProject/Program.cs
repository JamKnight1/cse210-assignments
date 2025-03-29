using System;

class Program
{
    private static string userChoice;
    private static string typeChoice;
    static void Main(string[] args)
    {
        

        while (userChoice != "9")
        {
            Console.WriteLine("Welcome to your Media List!");
            Console.WriteLine("Please select an option: ");

            Console.WriteLine("1. Create an Entry");
            Console.WriteLine("2. Complete an Entry");
            Console.WriteLine("3. Display List");
            Console.WriteLine("4. Write a Review");
            Console.WriteLine("5. View a Review");
            Console.WriteLine("6. Save a Recommendation");
            Console.WriteLine("7. View Recommendation List");
            Console.WriteLine("8. Delete Recommendation");
            Console.WriteLine("9. Quit");

            userChoice = Console.ReadLine();

            switch(userChoice)
            {
                case "1":
                    Console.WriteLine("What type of media do you want to add?");

                    Console.WriteLine("1. Book");
                    Console.WriteLine("2. Game");
                    Console.WriteLine("3. Movie");
                    Console.WriteLine("4. Show");

                    typeChoice = Console.ReadLine();
                    break;
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
                    break;
                case "default":
                    Console.WriteLine("Sorry, that's not an option");
                    break;
            }
        }

    }
}
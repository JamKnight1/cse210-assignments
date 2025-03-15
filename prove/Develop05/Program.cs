using System;

class Program
{
    private static string userChoice = "";
    private static string _goalChoice;
    private static List<Goal> _goals = new List<Goal>();
    

    static void Main(string[] args)
    {
        MenuOptions goals = new MenuOptions();
        while (userChoice != "6")
        {   
            Goal.DisplayScore();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");
            userChoice = Console.ReadLine();

            switch(userChoice)
            {
                case "1":
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("1. Simple Goals");
                    Console.WriteLine("2. Checklist Goals");
                    Console.WriteLine("3. Eternal Goals");
                    Console.Write("What type of goal would you like to create? ");
                    _goalChoice = Console.ReadLine();

                    switch (_goalChoice)
                    {
                        case "1":
                            Simple g1 = new Simple();
                            g1.CreateChildGoal();
                            _goals.Add(g1);
                            break;
                        case "2":
                            Checklist g2 = new Checklist();
                            g2.CreateChildGoal();
                            _goals.Add(g2);
                            break;
                        case "3":
                            Eternal g3 = new Eternal();
                            g3.CreateChildGoal();
                            _goals.Add(g3);
                            break;
                        case "default":
                            Console.WriteLine("That is not an option. Try again.");
                            break;
                        }
                break;
                case "2":
                    goals.DisplayGoals();
                    break;
                case "3":
                    goals.SaveGoals();
                    break;
                case "4":
                    goals.LoadGoals();
                    break;
                case "5":
                    goals.RecordEventInTracker();
                    break;
                case "6":
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("That is not a valid option. Try again");
                    break;
            }
        }
    }
}
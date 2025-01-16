using System;
using System.Globalization;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string user = PromptUserName();
        int number = PromptUserNumber();
        int numbersq = SquareNumber(number);
        DisplayResult(user, numbersq);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your user name: ");
        string user = Console.ReadLine();
        return user;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string numberstr = Console.ReadLine();
        int number = int.Parse(numberstr);
        return number;
    }
    static int SquareNumber(int number)
    {
        int numbersq = number * number;
        return numbersq;
    }
    static void DisplayResult(string user, int numbersq)
    {
        Console.WriteLine($"{user}, the square of your number is {numbersq}");
    }
    
}
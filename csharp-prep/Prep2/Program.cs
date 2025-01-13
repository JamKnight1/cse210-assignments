using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letter = "";

        if (grade >= 90)
        {
            Console.Write("Congrats! You got an ");
            letter = "A";
        }
        else if(grade >= 80)
        {
            Console.Write("Nice, you got a ");
            letter = "B";
        }
        else if(grade >= 70)
        {
            Console.Write("You got a ");
            letter = "C";
        }
        else if(grade >=60)
        {
            Console.Write("Hold on! You got a ");
            letter = "D";
        }
        else 
        {
            Console.Write("Yikes, you got an ");
            letter = "F";
        }

        Console.WriteLine(letter);

        if (grade >= 70)
        {
            Console.WriteLine("Congrats, you passed the class!");
        }
        else
        {
            Console.WriteLine("Nice try, but you failed the class.");
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string magicstr = Console.ReadLine();
        // int magic = int.Parse(magicstr);

        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1,101);

        Console.Write("What is your guess? ");
        string guessstr = Console.ReadLine();
        int guess = int.Parse(guessstr);

        do
        {
            if (guess > magic)
            {
                Console.WriteLine("Lower");
                Console.Write("What is your guess? ");
                guessstr = Console.ReadLine();
                guess = int.Parse(guessstr);
            }
            else if (guess < magic)
            {
                Console.WriteLine("Higher");
                Console.Write("What is your guess? ");
                guessstr = Console.ReadLine();
                guess = int.Parse(guessstr);
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while(guess != magic);
    }
}
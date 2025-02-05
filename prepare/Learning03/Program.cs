using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new Fraction object
        Fraction fraction = new Fraction();

        // Get the top and bottom numbers from the user
        Console.WriteLine("Give a top number: ");
        int top = int.Parse(Console.ReadLine());
        Console.WriteLine("Give a bottom number: ");
        int bottom = int.Parse(Console.ReadLine());

        // Set the top and bottom numbers in the Fraction object
        fraction.SetTop(top);
        fraction.SetBottom(bottom);

        // Display the fraction as a string
        Console.WriteLine(fraction.GetFractionString());

        // Display the fraction as a decimal
        Console.WriteLine(fraction.GetDecimalValue());
    }
}
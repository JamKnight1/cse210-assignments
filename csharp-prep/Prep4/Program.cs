using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

// Shopping Cart Program

/*
Nouns (variables)
=====
- item
    - price
    - amount
    - name
- cart

verbs (functions)
=====
- add to cart
- remove from cart
- Total
- clear
- display
 */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Shopping Cart Program\n");
        List<string> names = new List<string>();
        List<double> prices = new List<double>();

        bool done = false;
        while (!done)
        {
            {
                DisplayMenu();
                string choice = GetChoice();
                if (choice == "1")
                {
                    AddToCart(names, prices); // prompt to user, and the cart
                }
                else if (choice == "2")
                {
                    RemoveFromCart();
                }
                else if (choice == "3")
                {
                    Display(names, prices);
                }
                else if (choice == "4")
                {
                    double total = CalcTotal(prices);
                    Console.WriteLine($"Total is {total}");
                }
                else if (choice == "5")
                {
                    // exit
                    done = true;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }
        }
    }

    static string GetChoice()
    {
        Console.Write("Enter choice: ");
        string choice = Console.ReadLine();
        return choice;
    }
    
    static void DisplayMenu()
    {
        Console.WriteLine("1) Add");
        Console.WriteLine("2) Remove");
        Console.WriteLine("3) Display");
        Console.WriteLine("4) Total");
        Console.WriteLine("5) Quit\n");
    }
    
    static void AddToCart(List<string> names, List<double> prices)
    {
        Console.Write("Enter Name of item: ");
        string name = Console.ReadLine();

        Console.Write("Enter price of item: ");
        string priceString = Console.ReadLine();

        double price = Convert.ToDouble(priceString);
        
        names.Add(name);
        prices.Add(price);
    }

    static void RemoveFromCart()
    {
    }

    static double CalcTotal(List<double> prices)
    {
        double total = 0;

        foreach (var price in prices)
        {
            total += price;
        }
        
        return total;
    }

    static void Clear()
    {
        
    }

    static void Display(List<string> names, List<double> prices)
    {
        Console.WriteLine("Cart");
        Console.WriteLine("=============================");
        for (int i = 0; i < names.Count; i++)
        {
            Console.WriteLine($"{names[i],15}:  {prices[i]}");
        }

        Console.WriteLine();
    }
}


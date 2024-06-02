using System;

class Program
{
    static void Main()
    {
        Console.Write("Welcome to my Ticket Price Calculator. Please enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        double ticketPrice = 10.00; // Base ticket price

        if (age <= 12 || age >= 65)
        {
            ticketPrice = 7.00; // Discounted price for seniors and children
        }

        Console.WriteLine("The ticket price is GHC" + ticketPrice);
    }
}

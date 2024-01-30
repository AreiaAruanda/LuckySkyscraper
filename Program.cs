using Microsoft.VisualBasic;
using System;
using System.Numerics;
using System.Transactions;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> fakeLevels = new List<string>();

        int i = 1;
        for (i = 1; i < 150; i++)
        {
            var line = i.ToString();
            if (line.EndsWith('4'))
                continue;
            else if (i % 100 == 13)
                continue;
            else
                fakeLevels.Add(i.ToString());
        }

        Console.Write("Enter your floor number: ");
        string realLevelInput = Console.ReadLine();
        if (int.TryParse(realLevelInput, out int floorNumber))
        {
            // Parsing successful, use the 'floorNumber' variable
            Console.WriteLine($"You entered floor number: {floorNumber}");
            Console.WriteLine($"The fake floor number is {fakeLevels[floorNumber-1]}");
        }
        else
        {
            // Parsing failed, error handling
            Console.WriteLine("Invalid input. Please enter a valid integer for the floor number.");
        }
    }
}
//Learned at 10 - Sep - 2023
using System;
#nullable enable

string? number;
int numeric = 0;

Console.WriteLine("Insert a number between 5 and 10:");

do
{
    number = Console.ReadLine();
    int.TryParse(number, out numeric);
    if (numeric < 5 || numeric > 10)
    {
        Console.WriteLine("Please insert a number valid between 5 and 10");
    }
    else
    {
        Console.WriteLine($"You insert {numeric}, is a number valid.");
        break;
    }
} while (number != null);

//Learn at 10 - Sep - 2023
#nullable enable
using System;


string? client;
string valid = "";
bool validEntry = false;
Console.WriteLine("Please select: Administrator | Manager | User");

do
{

    client = Console.ReadLine();
    if (client != null)
    {
        valid = client.Trim();
    }
    if (valid.ToLower() == "administrator" || valid.ToLower() == "manager" || valid.ToLower() == "user")
    {
        validEntry = true;
    }
    else
    {
        Console.WriteLine($"The role name that you entered, \"{valid}\" is not valid. Enter your role name (Administrator, Manager, or User)");
    }
} while (validEntry != true);
Console.WriteLine($"Your input value ({valid}) has been accepted.");
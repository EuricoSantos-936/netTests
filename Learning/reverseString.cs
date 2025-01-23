//23 - Jan - 2025

using System;

string originalWord = "";
string reversedWord = "";

Console.WriteLine("Please enter a string to reverse:");

originalWord = Console.ReadLine();

for (int i = originalWord.Length - 1; i >= 0; i--){
    reversedWord += originalWord[i];
}
Console.WriteLine("The reversed string is: " + reversedWord);


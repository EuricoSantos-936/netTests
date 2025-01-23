// Learn at 07 - Sep - 2023
using System;

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

Console.WriteLine(daysUntilExpiration);
if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.\nPlease, contact for renewal.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration >= 6)
{
    Console.WriteLine($"Your subscription haves {daysUntilExpiration} days left.");
}
if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}

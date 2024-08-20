Random random = new();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
    Console.WriteLine("SUBSCRIPTION IS EXPIRED.");
else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    Console.WriteLine($"SUBSCRIPTION EXPIRES WITHIN A DAY!\nRENEW NOW AND SAVE {discountPercentage}%!");
}
else if (daysUntilExpiration <= 5)
{
    discountPercentage = 10;
    Console.WriteLine($"SUBSCRIPTION EXPIRES WITHIN {daysUntilExpiration} DAYS!\nRENEW NOW AND SAVE {discountPercentage}%!");
}
else if (daysUntilExpiration <= 10)
    Console.WriteLine("SUBSCRIPTION EXPIRES SOON. RENEW NOW!");
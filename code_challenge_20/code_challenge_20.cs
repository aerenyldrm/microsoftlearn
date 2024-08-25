using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");

string customerName = "Ms. BARROS";
string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;
string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName}");
Console.WriteLine
(
    $"As a customer of {currentProduct}, excited to tell about a recent financial product that dramatically increase return.\n"
);
Console.WriteLine($"Currently, own {currentShares:N2} shares at a return of {currentReturn:P2}.\n");
Console.WriteLine
(
    $"Recent product, {newProduct} offers return of {newReturn:P2}.  Given current volume, potential profit is {newProfit:C}\n"
);

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage = comparisonMessage + currentProduct.PadRight(20) + $"{currentReturn:P2}".PadRight(10) + $"{currentProfit:C}\n";
comparisonMessage = comparisonMessage + newProduct.PadRight(20) + $"{newReturn:P2}".PadRight(10) + $"{newProfit:C}";

Console.WriteLine(comparisonMessage);
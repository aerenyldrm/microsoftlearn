using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");

Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

void PlayGame() 
{
    var play = true;

    while (play) 
    {
        var target = random.Next(1, 6);
        var roll = random.Next(1, 7);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay()
{
    string? readResult = Console.ReadLine();

    while (readResult == null || (readResult.ToLower().Trim() != "y" && readResult.ToLower().Trim() != "n"))
    {
        Console.WriteLine("\nPlay again? (Y/N)");
        readResult = Console.ReadLine();
    }

    if (readResult.ToLower().Trim() == "y")
        return true;
    else
        return false;
}

string WinOrLose(int roll, int target)
{
    return roll > target ? "WIN" : "LOSE";
}
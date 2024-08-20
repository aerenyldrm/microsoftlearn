string? inputEntry;
bool check = false;

Console.WriteLine("ENTER ROLE NAME (ADMINISTRATOR, MANAGER, OR USER)");

do
{
    inputEntry = Console.ReadLine().Trim().ToLower();
    if (inputEntry == "administrator" || inputEntry == "manager" || inputEntry == "user")
    {
        Console.WriteLine($"INPUT VALUE {inputEntry} IS ACCEPTED.");
        check = true;
    }
    else
        Console.WriteLine($"ROLE NAME ENTERED \"{inputEntry}\" IS NOT VALID. ENTER ROLE NAME (ADMINISTRATOR, MANAGER, OR USER)");
} while (check == false);
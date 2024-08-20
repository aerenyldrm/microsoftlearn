string? inputEntry;
int validNumber = 0;
bool validInvalid = false;

Console.WriteLine("ENTER AN INTEGER VALUE BETWEEN 5 AND 10 INCLUSIVE.");

do
{
    inputEntry = Console.ReadLine();
    if (int.TryParse(inputEntry, out validNumber))
        if (validNumber <= 10 && validNumber >= 5)
        {
            validInvalid = true;
            Console.WriteLine($"INPUT VALUE ({validNumber}) IS ACCEPTED.");
        }
        else
            Console.WriteLine($"ENTERED {validNumber}. PLEASE ENTER A NUMBER BETWEEN 5 AND 10 INCLUSIVE.");
    else
        Console.WriteLine("INVALID NUMBER, TRY AGAIN.");
} while (validInvalid == false);
using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");

string[] values = { "12.3", "45", "ABC", "11", "DEF" };
string message = "MESSAGE: ";
float total = 0;

foreach(string value in values)
{
    float checkFloat;
    if (float.TryParse(value, out checkFloat))
        total += checkFloat;
    else 
        message += value;
}

Console.WriteLine(message);
Console.WriteLine($"TOTAL: {total}");
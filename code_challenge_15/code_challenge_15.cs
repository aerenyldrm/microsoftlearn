string[] myStrings = new string[2] { "LOVE PIZZA. LOVE ROAST CHICKEN. LOVE SALAD", "LOVE ENTIRE" };

for (int i = 0; i < myStrings.Length; i++)
{
    int index = myStrings[i].IndexOf(".");
    while (index != -1)
    {
        Console.WriteLine(myStrings[i].Substring(0, index).TrimStart());
        myStrings[i] = myStrings[i].Remove(0, index + 1);
        index = myStrings[i].IndexOf(".");
    }
    Console.WriteLine(myStrings[i].TrimStart());
}
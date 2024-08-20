int[] numbers = [4, 8, 15, 16, 23, 42];
int total = 0;
bool include = false;

foreach (int number in numbers)
{
    total += number;

    if (number == 42)
        include = true;
}

if (include) 
    Console.WriteLine("SET CONTAINS 42.");

Console.WriteLine($"TOTAL: {total}");
string permission = "Manager";
int level = 53;

if (permission.Contains("Admin"))
{
    if (level > 55)
        Console.WriteLine("WELCOME SUPER ADMIN USER.");
    else
        Console.WriteLine("WELCOME ADMIN USER.");
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
        Console.WriteLine("CONTACT AN ADMIN FOR ACCESS.");
    else
        Console.WriteLine("DO NOT CARRY PRIVILEGE.");
}
else
    Console.WriteLine("DO NOT CARRY PRIVILEGE.");
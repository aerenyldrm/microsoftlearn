string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderStreamArray = orderStream.Split(",");
Array.Sort(orderStreamArray);
foreach (string orderID in orderStreamArray)
{
    if (orderID.Length != 4)
        Console.WriteLine(orderID + "\t- ERROR");
    else
        Console.WriteLine(orderID);
}
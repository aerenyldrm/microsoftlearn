string sku = "01-MN-L";
string[] product = sku.Split('-');
string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat Shirt";
        break;
    case "02":
        type = "T-shirt";
        break;
    case "03":
        type = "Sweat Pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "GR":
        color = "Gray";
        break;
    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "A Size Fits Entire";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// FIND QUANTITY
string opening = "<span>";
string closing = "</span>";
int openingPosition = input.IndexOf(opening);
int closingPosition = input.IndexOf(closing);
openingPosition += opening.Length;
int length = closingPosition - openingPosition;

quantity = $"QUANTITY: {input.Substring(openingPosition, length)}";

// FIND OUTPUT
opening = "<div>";
closing = "</div>";
openingPosition = input.IndexOf(opening);
closingPosition = input.IndexOf(closing);
openingPosition += opening.Length;
length = closingPosition - openingPosition;

output = $"OUTPUT: {input.Substring(openingPosition, length).Replace("trade", "reg")}";

Console.WriteLine(quantity);
Console.WriteLine(output);
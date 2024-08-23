int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = Convert.ToInt32(value1 / value2);
Console.WriteLine($"DIVIDE value1 BY value2, DISPLAY RESULT AS INT: {result1}");

decimal result2 = value2 / (decimal) value3;
Console.WriteLine($"DIVIDE value2 BY value3, DISPLAY RESULT AS DECIMAL: {result2}");

float result3 = value3 / value1;
Console.WriteLine($"DIVIDE value3 BY value1, DISPLAY RESULT AS FLOAT: {result3}");
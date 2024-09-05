/*  
This code instantiates a value and then calls the ChangeValue method
to update the value. The code then prints the updated value to the console.
*/
int x = 5;

Console.WriteLine(ChangeValue(x));

int ChangeValue(int value) 
{
    value = 10;
    return value;
}
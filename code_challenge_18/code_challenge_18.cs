string pangram = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
string updatedPangram = "";
int counter = 1;

string[] wordArray = pangram.Split(' ');
foreach (string word in wordArray)
{
    char[] characterArray = word.ToCharArray();
    Array.Reverse(characterArray);
    string updatedWord = String.Join("", characterArray);
    updatedPangram += updatedWord;
    if (counter != wordArray.Length)
        updatedPangram += ' ';
}
Console.WriteLine(updatedPangram);
using System.Diagnostics.Tracing;

string pangram = "The quick brown fox jumps over the lazy dog";
string reversedPangram = "";
foreach (string word in pangram.Split(' '))
{
    string reverseWord = "";
    for (int i = word.Length - 1; i >= 0; i--)
    {
        reverseWord += word[i];
    }
    reversedPangram += reverseWord + " ";
}

Console.WriteLine(reversedPangram);
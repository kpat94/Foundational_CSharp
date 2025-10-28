string pangram = "The quick brown fox jumps over the lazy dog";

string[] pangramStrings = pangram.Split(" ");

foreach (string pangramString in pangramStrings)
{
    char[] pangramStringChars = pangramString.ToCharArray();
    Array.Reverse(pangramStringChars);
    Console.Write(new String(pangramStringChars) + " ");
}

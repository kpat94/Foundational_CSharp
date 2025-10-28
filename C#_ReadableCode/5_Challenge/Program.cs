/*
    The purpose of this code is to reverse a string
    and count the number of times 'o' appears.
*/

string str = "The quick brown fox jumps over the lazy dog.";
char[] charMessage = str.ToCharArray();
Array.Reverse(charMessage);

int oCount = 0;
foreach (char i in charMessage) 
{ 
    if (i=='o') 
    { 
        oCount++; 
    }
}

string newMessage = new(charMessage);
Console.WriteLine(newMessage);

Console.WriteLine($"'o' appears {oCount} times.");
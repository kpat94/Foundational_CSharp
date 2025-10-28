/*
string message = "(What if) there are (more than) one (set of parenthesis)?";
const string open = "(";
const string close = ")";

while (true)
{
    int openingPosition = message.IndexOf(open);
    if(openingPosition == -1) break;

    openingPosition += open.Length;
    int closingPosition = message.IndexOf(close);
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    message = message.Substring(closingPosition + 1);
}
*/

/*
string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
Console.WriteLine($"Searching THIS Message: {message}");
char[] openSymbols = { '[', '{', '(' };
int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    char matchingSymbol = default;

    switch(currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "(":
            matchingSymbol = ')';
            break;
        case "{":
            matchingSymbol = '}';
            break;
    }

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

}
*/

string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);

string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);

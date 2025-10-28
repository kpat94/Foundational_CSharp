string[] values = { "12.3", "45", "ABC", "11", "DEF"};
string message = "";
decimal total = 0m;
decimal number;

foreach(string value in values)
{
    if(decimal.TryParse(value, out number))
    {
        total += number;
    }
    else
    {
        message += value;
    }
}

if(!message.Equals(""))
    Console.WriteLine($"Message: {message}");

if(total > 0)
    Console.WriteLine($"Total: {total}");

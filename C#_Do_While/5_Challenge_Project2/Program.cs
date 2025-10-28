Console.WriteLine("Please enter your role from the following : ");
Console.WriteLine("  1. Administrator");
Console.WriteLine("  2. Manager");
Console.WriteLine("  3. User");

var validInput = false;
string input;
var message = "";
List<string> roles = ["Administrator", "Manager", "User"];

do
{
    input = Console.ReadLine();

    if (input != null)
    {
        message = CheckValidInput(input) == true
        ? $"Your input ({input}) has been accepted." 
        : $"Could not accept input ({input}). Please enter one of the mentioned roles.";

    }
        
    Console.WriteLine(message);

}while(!validInput);

bool CheckValidInput(string role) 
{
    foreach(string item in roles)
    {
        if (role.Trim().ToLower().Equals(item.ToLower()))
        {
            validInput = true;
            return true;
        }
            
    }

    return false;

}



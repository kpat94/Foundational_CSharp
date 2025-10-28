Random random = new Random();

if(ShouldPlay())
{
    PlayGame();
}

bool ShouldPlay()
{
    string userInput;

    Console.WriteLine("Would you like to play? (Y/N)");
    userInput = Console.ReadLine()!;
    
    return userInput!.Trim().ToLower().Equals("y");
}

bool WinOrLose(long target, long roll)
{
    bool result = (roll > target);
    string message = (result) ? "You win": "You lose";
    Console.WriteLine(message);
    return result;
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = random.NextInt64(1, 6);
        var roll = random.NextInt64(1, 7);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        WinOrLose(target, roll);
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}
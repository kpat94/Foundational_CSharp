using System;

Random random = new Random();
Console.CursorVisible = false;
int height = Console.WindowHeight - 1;
int width = Console.WindowWidth - 5;
bool shouldExit = false;

// Console position of the player
int playerX = 0;
int playerY = 0;

// Console position of the food
int foodX = 0;
int foodY = 0;

// Available player and food strings
string[] states = { "('-')", "(^-^)", "(X_X)" };
string[] foods = { "@@@@@", "$$$$$", "#####" };

// Current player string displayed in the Console
string player = states[0];

// Index of the current food
int food = 0;

// Track food consumed
int foodConsumed = 0;

InitializeGame();
while (!shouldExit)
{

    // Change speed according to player.
    if(player.Equals(states[1]))
        Move(changeSpeed: false, detectNonDirectional: true);
    else if(player.Equals(states[0]))
        Move(changeSpeed: false, detectNonDirectional: true);
    else
        Move(detectNonDirectional: true);

    // Close the game if console is resized
    if (TerminalResized())
    {
        Console.Clear();
        FreezePlayer();
        Console.WriteLine("Console was resized. Program exiting.");
        shouldExit = true;
    }

    // Change player according to food consumed.
    if (PlayerConsumedFood())
    {
        ShowFood();
        if (foodConsumed == 2)
        {
            ChangePlayer(playerIndex: foodConsumed);
            FreezePlayer();
        }
        else
        {
            ChangePlayer();
        }
            
    }

}

bool PlayerConsumedFood()
{
    if (foodY == playerY)
    {
        if (foodX == playerX)
        {
            foodConsumed = food;
            return true;
        }

    }

    return false;
}

// Returns true if the Terminal was resized 
bool TerminalResized()
{
    return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
}

// Displays random food at a random location
void ShowFood()
{
    // Update food to a random index
    food = random.Next(0, foods.Length);

    // Update food position to a random location
    foodX = random.Next(0, width - player.Length);
    foodY = random.Next(0, height - 1);

    // Display the food at the location
    Console.SetCursorPosition(foodX, foodY);
    Console.Write(foods[food]);

}

// Changes the player to match the food consumed
void ChangePlayer(int playerIndex = -1)
{
    player = (playerIndex == -1) ? states[food] : states[playerIndex];
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Temporarily stops the player from moving
void FreezePlayer()
{
    System.Threading.Thread.Sleep(7000);
}

// Reads directional input from the Console and moves the player
void Move(bool changeSpeed = false, bool detectNonDirectional = false)
{
    int lastX = playerX;
    int lastY = playerY;
    var moveInput = Console.ReadKey(true).Key;
    ConsoleKey[] acceptedMoves = { ConsoleKey.UpArrow, ConsoleKey.DownArrow, ConsoleKey.LeftArrow, ConsoleKey.RightArrow };
    int speedIncrement = changeSpeed ? 3 : 1;

    if (detectNonDirectional == true)
    {
        if (!(Array.Exists(acceptedMoves, move => moveInput == move)))
            shouldExit = true;
    }

    switch (moveInput)
    {
        case ConsoleKey.UpArrow:
            playerY--;
            break;
        case ConsoleKey.DownArrow:
            playerY++;
            break;
        case ConsoleKey.LeftArrow:
            playerX-=speedIncrement;
            break;
        case ConsoleKey.RightArrow:
            playerX+=speedIncrement;
            break;
        case ConsoleKey.Escape:
            shouldExit = true;
            break;
    }

    // Clear the characters at the previous position
    Console.SetCursorPosition(lastX, lastY);
    for (int i = 0; i < player.Length; i++)
    {
        Console.Write(" ");
    }

    // Keep player position within the bounds of the Terminal window
    playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
    playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

    // Draw the player at the new location
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Clears the console, displays the food and player
void InitializeGame()
{
    Console.Clear();
    ShowFood();
    Console.SetCursorPosition(0, 0);
    Console.Write(player);
}
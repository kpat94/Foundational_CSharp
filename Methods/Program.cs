// See https://aka.ms/new-console-template for more information
Random dice = new Random();
int roll = dice.Next(1, 7);
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine("First role : {0}", roll1);
Console.WriteLine("Second role: {0}", roll2);
Console.WriteLine("Third role : {0}", roll3);
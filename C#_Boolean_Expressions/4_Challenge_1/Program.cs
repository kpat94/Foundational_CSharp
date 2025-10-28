Random random = new Random();
int headsOrTails = random.Next(2);
Console.WriteLine($"{(headsOrTails >= 1 ? "heads" : "tails")}");
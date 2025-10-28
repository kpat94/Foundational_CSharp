
int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Set result1
int result1 = 0;
result1 = Convert.ToInt32(value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Set result2
decimal result2 = 0m;
result2 = value2 / Convert.ToDecimal(value3);
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Set result3
float result3 = 0f;
result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

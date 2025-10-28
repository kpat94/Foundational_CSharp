/*
string[] fraudulentOrderIds = new string[3];

fraudulentOrderIds[0] = "A123";
fraudulentOrderIds[1] = "B456";
fraudulentOrderIds[2] = "C789";
//fraudulentOrderIds[3] = "D000";
*/

string[] fraudulentOrderIds = {"A123", "B456", "C789"};

Console.WriteLine($"First: {fraudulentOrderIds[0]}");
Console.WriteLine($"Second: {fraudulentOrderIds[1]}");
Console.WriteLine($"Third: {fraudulentOrderIds[2]}");

fraudulentOrderIds[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIds[0]}");

Console.WriteLine($"There are {fraudulentOrderIds.Length} fraudulent orders to process.");

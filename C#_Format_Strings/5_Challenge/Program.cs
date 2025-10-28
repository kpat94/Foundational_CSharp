
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

string formattedLine1 = $"Dear {customerName}, \nAs a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return. \n";
string formattedLine2 = $"\nCurrently, you own {currentShares:N2} shares at a return of {currentReturn:P2}. \n";
string formattedLine3 = $"\nOur new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C2}. \n";

string outputMessage = formattedLine1 + formattedLine2 + formattedLine3;

Console.WriteLine(outputMessage);

Console.WriteLine("Here's a quick comparison:\n");
string currentProductRow = currentProduct.PadRight(24) + String.Format("{0:P2}", currentReturn).PadRight(6) + String.Format("{0:C2}", currentProfit).PadLeft(20);
string newProductRow = newProduct.PadRight(24) + String.Format("{0:P2}", newReturn).PadRight(6) + String.Format("{0:C2}", newProfit).PadLeft(20);

string comparisonMessage = currentProductRow + "\n" + newProductRow;
Console.WriteLine(comparisonMessage);
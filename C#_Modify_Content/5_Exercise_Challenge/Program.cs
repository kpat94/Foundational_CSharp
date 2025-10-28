const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

string openingQuantityTag = "<span>";
string closingQuantityTag = "</span>";

string openingTag = "<div>";
string closingTag = "</div>";

string htmlTradeMark = "&trade;";
string htmlRegistered = "&reg;";

int openingQuantityTagPosition = input.IndexOf(openingQuantityTag);
int closingQuantityTagPosition = input.IndexOf(closingQuantityTag);
int quantityLength = closingQuantityTagPosition - (openingQuantityTagPosition + openingQuantityTag.Length);

quantity = input.Substring(openingQuantityTagPosition + openingQuantityTag.Length, quantityLength);

output = input.Remove(input.IndexOf(openingTag), openingTag.Length);
output = output.Remove(output.IndexOf(closingTag), closingTag.Length);
output = output.Replace(htmlTradeMark, htmlRegistered);

Console.WriteLine("Quantity: {0}",quantity);
Console.WriteLine("Output: {0}", output);

/*
    The following code creates five random orderIDs 
    to test the fraud detection process. OrderIds
    consist of a letter from A to E, and a three 
    digit number. Ex. A123.
*/
Random random = new Random();
string[] orderIds = new string [5];

for (int i = 0; i < orderIds.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");
    orderIds[i] = prefix + suffix;
}

foreach(var orderID in orderIds){
    Console.WriteLine(orderID);
}
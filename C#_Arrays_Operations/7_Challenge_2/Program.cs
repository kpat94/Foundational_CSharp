string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderIds = orderStream.Split(',');
Array.Sort(orderIds);

foreach (string orderId in orderIds)
{
    String output = orderId.Length != 4 ? $"{orderId} \t - Error" : $"{orderId}";
    Console.WriteLine(output);
}

string[] myStrings = new string[2] 
{ "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

// Iterate over the string array.
foreach (var myString in myStrings)
{
    // Split into sentences if the string contains '.'
    if(myString.Contains('.'))
    {
        string[] tokens = myString.Split('.');

        // Display each sentence
        foreach (var sentence in tokens)
        {
            Console.WriteLine(sentence.TrimStart());
        }
    }
    // Processing not required if the string does not contain a '.'
    else
    {
        Console.WriteLine(myString);
    }

}
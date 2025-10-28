string[][] userEnteredValues = new string[][]
{
    new string[] { "1", "2", "3" },
    new string[] { "1", "two", "3"},
    new string[] { "0", "1", "2"}
};

string overallStatusMessage = "";

try
{
    Workflow1(userEnteredValues);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("An error occured during 'Workflow1'.");
    Console.WriteLine(ex.Message);
}


static void Workflow1(string[][] userEnteredValues)
{
    string operationStatusMessage = "good";
    string processStatusMessage = "";

    foreach (string[] userEntries in userEnteredValues)
    {
        try
        {
            Process1(userEntries);

            Console.WriteLine("'Process1' completed successfully.");
            Console.WriteLine();
        }
        catch (FormatException ex)
        {
            Console.WriteLine("'Process1' encountered an issue, process aborted.");
            Console.WriteLine(ex.Message);
        }

    }

}

static void Process1(String[] userEntries)
{
    string processStatus = "clean";
    string returnMessage = "";
    int valueEntered;

    foreach (string userValue in userEntries)
    {
        bool integerFormat = int.TryParse(userValue, out valueEntered);

        if (integerFormat == true)
        {
            try
            {
                checked
                {
                    int calculatedValue = 4 / valueEntered;
                }
            }
            catch (DivideByZeroException ex)
            {
                throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
            }
        }
        else
        {
            throw new FormatException("Invalid data. User input values must be valid integers.");
        }
    }

}
Console.WriteLine("Please enter a number between 5 and 10.");

string? inputNumber =  null;
bool validInt;
bool validInput;
bool checkValidNumber(int num) => (num >= 5 && num <=10) ? validInput = true : validInput = false; 

do
{
    inputNumber = Console.ReadLine();

    int number = 0;
    if(inputNumber != null)
        validInt = Int32.TryParse(inputNumber, out number);

    string checkResult = checkValidNumber(number) == true ? "Accepted input" : "Please check your input and try again.";
    Console.WriteLine(checkResult);

}
while(validInput == false);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-\n");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Welcome to the Binary to Decimal Converter!");
Console.ResetColor();

string binary;
int decimalNumber = 0;
bool isValid = false;

while (isValid == false)
{
    Transactions();
}

/// <summary>
///  <para> This method is responsible for the main transactions of the program. </para>
///  <para> It calls the GetBinaryNumber() method to get the binary number from the user. </para>
///  <para> It checks if the binary number is 8 bits long. </para>
///  <para> If the binary number is not 8 bits long, it calls the Transactions() method again. </para>
///  <para> If the binary number is 8 bits long, it checks if the binary number contains only 0s and 1s. </para>
///  <para> If the binary number contains other characters, it calls the Transactions() method again. </para>
/// <para> If the binary number is valid, it calls the ConvertBinaryToDecimal() method to convert the binary number to decimal. </para>
/// <para> It then calls the ShowResultMessage() method to display the result. </para>
///   </summary>
void Transactions()
{
    GetBinaryNumber();
    if (binary.Length == 8)
    {
        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[i] != '0' && binary[i] != '1')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid binary number. Please try again.");
                Console.ResetColor();
                isValid = false;
                break;
            }
            else
            {
                isValid = true;
            }
        }

        if (isValid == false)
        {
            Transactions();

        }
        else
        {
            ConvertBinaryToDecimal();
            ShowResultMessage();
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The binary number is not 8 bits long. Please try again.");
        Console.ResetColor();
        Transactions();
    }
}

/// <summary>
/// <para> This method converts the binary number to decimal. </para>
/// <para> It iterates through the binary number from right to left. </para>
/// <para> It multiplies each digit of the binary number by 2 raised to the power of its position. </para>
/// <para> It then adds the result to the decimalNumber variable. </para>
/// </summary>
void ConvertBinaryToDecimal()
{
    for (int i = 0; i < binary.Length; i++)
    {
        decimalNumber += int.Parse(binary[binary.Length - 1 - i].ToString()) * (int)Math.Pow(2, i);
    }
}


/// <summary>
/// <para> This method gets the binary number from the user. </para>
/// </summary>
void GetBinaryNumber()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Please enter a binary number: ");
    Console.ResetColor();
    binary = Console.ReadLine();
}

/// <summary>
/// <para> This method displays the result of the conversion. </para>
/// </summary>
void ShowResultMessage()
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine($"The decimal equivalent of \u001b[34m({binary})2\u001b[0m is \u001b[34m({decimalNumber})10\u001b[0m.");
    Console.ResetColor();
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\n-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-");
Console.ResetColor();
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

void ConvertBinaryToDecimal()
{
    for (int i = 0; i < binary.Length; i++)
    {
        decimalNumber += int.Parse(binary[binary.Length - 1 - i].ToString()) * (int)Math.Pow(2, i);
    }
}

void GetBinaryNumber()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Please enter a binary number: ");
    Console.ResetColor();
    binary = Console.ReadLine();
}

void ShowResultMessage()
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine($"The decimal equivalent of \u001b[34m({binary})2\u001b[0m is \u001b[34m({decimalNumber})10\u001b[0m.");
    Console.ResetColor();
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\n-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-");
Console.ResetColor();
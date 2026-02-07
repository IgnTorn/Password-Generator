using System.Security.Cryptography;
using System.Text;

bool notGenerated = true;
string upperChoice = string.Empty, lowerChoice = string.Empty, numberChoice = string.Empty;
string specialChoice = string.Empty, excludeChoice = string.Empty, generateAgain = string.Empty;
int passLengthInt = 0, passAmountInt = 0;


while (notGenerated)
{
    bool valid = UserPreference();
    if (!valid)
        continue;

    GeneratePassword();
}

bool UserPreference()
{
    Console.Write("----------------\nPassword length: ");
    string passLength = Console.ReadLine().Trim();
    if (!int.TryParse(passLength, out passLengthInt))
    {
        Console.WriteLine("Please enter a valid number.");
        return false;
    }

    if (passLengthInt < 8 || passLengthInt > 20)
    {
        Console.WriteLine("Password length must be between 8 and 20");
        return false;
    }

    Console.Write("-------------------------------------\nHow many passwords should be created: ");
    string passAmount = Console.ReadLine().Trim();
    if (!int.TryParse(passAmount, out passAmountInt))
    {
        Console.WriteLine("Please enter a valid number.");
        return false;
    }
    if (passAmountInt < 1)
    {
        Console.WriteLine("Please enter a valid number greater than 0.");
        return false;
    }

    Console.Write("--------------------------\nInclude uppercase letters? (y/n): ");
    upperChoice = Console.ReadLine().Trim().ToLower();
    if (upperChoice != "y" && upperChoice != "n")
    {
        Console.WriteLine("Please enter a valid answer.");
        return false;
    }

    Console.Write("--------------------------\nInclude lowercase letters? (y/n): ");
    lowerChoice = Console.ReadLine().Trim().ToLower();
    if (lowerChoice != "y" && lowerChoice != "n")
    {
        Console.WriteLine("Please enter a valid answer.");
        return false;
    }

    Console.Write("----------------\nInclude numbers? (y/n): ");
    numberChoice = Console.ReadLine().Trim().ToLower();
    if (numberChoice != "y" && numberChoice != "n")
    {
        Console.WriteLine("Please enter a valid answer.");
        return false;
    }

    Console.Write("---------------------------\nInclude special characters? (y/n): ");
    specialChoice = Console.ReadLine().Trim().ToLower();
    if (specialChoice != "y" && specialChoice != "n")
    {
        Console.WriteLine("Please enter a valid answer.");
        return false;
    }

    Console.Write("-----------------------------\nExclude confusing characters? (y/n): ");
    excludeChoice = Console.ReadLine().Trim().ToLower();
    if (excludeChoice != "y" && excludeChoice != "n")
    {
        Console.WriteLine("Please enter a valid answer.");
        return false;
    }

    if (upperChoice == "n" && lowerChoice == "n" && numberChoice == "n" && specialChoice == "n")
    {
        Console.WriteLine("Please select at least one character type.");
        return false;
    }

    return true;
}

void GeneratePassword()
{
    List<char> charPool = new List<char>();

    if (upperChoice == "y")
        charPool.AddRange("ABCDEFGHIJKLMNOPQRSTUVWXYZ");

    if (lowerChoice == "y")
        charPool.AddRange("abcdefghijklmnopqrstuvwxyz");

    if (numberChoice == "y")
        charPool.AddRange("0123456789");

    if (specialChoice == "y")
        charPool.AddRange("!@#$%^&*()-_=+[]{}|;:,.<>?/");

    if (excludeChoice == "y")
        charPool.RemoveAll(c => "O0Il".Contains(c));

    if (charPool.Count == 0)
    {
        Console.WriteLine("No characters available to generate password.");
        return;
    }

    Console.WriteLine("-----------------------------");

    for (int i = 0; i < passAmountInt; i++)
    {
         StringBuilder password = new StringBuilder();

        for (int j = 0; j < passLengthInt; j++)
        {
            int index = RandomNumberGenerator.GetInt32(charPool.Count);
            password.Append(charPool[index]);
        }
        Console.WriteLine($"\nGenerated password {i + 1}: {password}");
    }
    Console.WriteLine("\n-----------------------------");

    do
    {
        Console.Write("\nGenerate again? (y/n): ");
        generateAgain = Console.ReadLine().Trim().ToLower();

        if (generateAgain != "y" && generateAgain != "n")
            Console.WriteLine("\n-----------------------------\nPlease enter a valid answer.\n-----------------------------");

    } while (generateAgain != "y" && generateAgain != "n");

    if (generateAgain == "n")
        notGenerated = false;
}
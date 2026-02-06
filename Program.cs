bool notGenerated = true;
string upperChoice = string.Empty, lowerChoice = string.Empty, numberChoice = string.Empty;
string specialChoice = string.Empty, excludeChoice = string.Empty;
int passLengthInt = 0, passAmountInt = 0; ;


while (notGenerated)
{
    UserPreferance();
    GeneratePassword();
}

void UserPreferance()
{
    // Get User Preferences
    Console.Write("----------------\nPassword length: ");
    string passLength = Console.ReadLine();
    if (!int.TryParse(passLength, out int passLengthInt))
    {
        Console.WriteLine("Please enter a valid number.");
        return;
    }

    if (passLengthInt < 8 || passLengthInt > 20)
    {
        Console.WriteLine("Password length must be between 8 and 20");
        return;
    }

    Console.Write("-------------------------------------\nHow many passwords should be created: ");
    string passAmount = Console.ReadLine();
    if (!int.TryParse(passAmount, out int passAmountInt))
    {
        Console.WriteLine("Please enter a valid number.");
        return;
    }
    if (passAmountInt < 1)
    {
        Console.WriteLine("Please enter a valid number greater than 0.");
        return;
    }

    // Get Character Types
    Console.Write("--------------------------\nInclude uppercase letters? (y/n): ");
    string upperChoice = Console.ReadLine();
    if (upperChoice.ToLower() != "y" && upperChoice.ToLower() != "n")
    {
        Console.WriteLine("Please enter a valid answer.");
        return;
    }

    Console.Write("--------------------------\nInclude lowercase letters? (y/n): ");
    string lowerChoice = Console.ReadLine();
    if (lowerChoice.ToLower() != "y" && lowerChoice.ToLower() != "n")
    {
        Console.WriteLine("Please enter a valid answer.");
        return;
    }

    Console.Write("----------------\nInclude numbers? (y/n): ");
    string numberChoice = Console.ReadLine();
    if (numberChoice.ToLower() != "y" && numberChoice.ToLower() != "n")
    {
        Console.WriteLine("Please enter a valid answer.");
        return;
    }

    Console.Write("---------------------------\nInclude special characters? (y/n): ");
    string specialChoice = Console.ReadLine();
    if (specialChoice.ToLower() != "y" && specialChoice.ToLower() != "n")
    {
        Console.WriteLine("Please enter a valid answer.");
        return;
    }

    Console.Write("-----------------------------\nExclude confusing characters? (y/n): ");
    string excludeChoice = Console.ReadLine();
    if (excludeChoice.ToLower() != "y" && excludeChoice.ToLower() != "n")
    {
        Console.WriteLine("Please enter a valid answer.");
        return;
    }

    if (upperChoice.ToLower() == "n" && lowerChoice.ToLower() == "n" && numberChoice.ToLower() == "n" && specialChoice.ToLower() == "n")
    {
        Console.WriteLine("Please select at least one character type.");
        return;
    }

    notGenerated = false;
}

void GeneratePassword()
{
    List<char> charPool = new List<char>();

    if (upperChoice.ToLower() == "y")
    {
        charPool.AddRange("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
    }

    if (lowerChoice.ToLower() == "y")
    {
        charPool.AddRange("abcdefghijklmnopqrstuvwxyz");
    }

    if (numberChoice.ToLower() == "y")
    {
        charPool.AddRange("0123456789");
    }

    if (specialChoice.ToLower() == "y")
    {
        charPool.AddRange("!@#$%^&*()-_=+[]{}|;:,.<>?/");
    }

    if (excludeChoice.ToLower() == "y")
    {
        charPool.RemoveAll(c => "O0Il".Contains(c));
    }
}
    // Generate
// Made By IgnTorn
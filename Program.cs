bool notGenerated = true;


while (notGenerated)
{
    UserPreferance();
}

void UserPreferance()
{
    // Get User Preferences
    Console.Write("----------------\nPassword Length: ");
    int passLength = Convert.ToInt32(Console.ReadLine());
    while (passLength != 8)
    {
        {
            if (passLength < 8)
            {
                Console.WriteLine("Password is too short. It should be at least 8 characters long.");
                return;
            }
            else if (passLength > 20)
            {
                Console.WriteLine("Password is too long. It should be no more than 20 characters long.");
                return;
            }

            Console.Write("-------------------------------------\nHow Many Passwords Should Be Created: ");
            int passAmount = Convert.ToInt32(Console.ReadLine());
            if (passAmount < 1)
            {
                Console.WriteLine("Please enter a valid number greater than 0.");
                return;
            }
        }
    }
    

    // Get Character Types
    Console.Write("--------------------------\nInclude Uppercase Letters? (y/n): ");
    string upperChoice = Console.ReadLine();
    if (upperChoice.ToLower() != "y" && upperChoice.ToLower() != "n")
    {
        Console.WriteLine("Please enter a valid answer.");
        return;
    }

    Console.Write("--------------------------\nInclude Lowercase Letters? (y/n): ");
    string lowerChoice = Console.ReadLine();
    if (lowerChoice.ToLower() != "y" && lowerChoice.ToLower() != "n")
    {
        Console.WriteLine("Please enter a valid answer.");
        return;
    }

    Console.Write("----------------\nInclude Numbers? (y/n): ");
    string numberChoice = Console.ReadLine();
    if (numberChoice.ToLower() != "y" && numberChoice.ToLower() != "n")
    {
        Console.WriteLine("Please enter a valid answer.");
        return;
    }

    Console.Write("---------------------------\nInclude Special Characters? (y/n): ");
    string specialChoice = Console.ReadLine();
    if (specialChoice.ToLower() != "y" && specialChoice.ToLower() != "n")
    {
        Console.WriteLine("Please enter a valid answer.");
        return;
    }

    Console.Write("-----------------------------\nExclude Confusing Characters? (y/n): ");
    string excludeChoice = Console.ReadLine();
    if (excludeChoice.ToLower() != "y" && excludeChoice.ToLower() != "n")
    {
        Console.WriteLine("Please enter a valid answer.");
        return;
    }

    notGenerated = false;
}

// Made By IgnTorn
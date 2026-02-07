##  Table of contents

- [Overview](#-overview)
- [Features](#-features)
- [Usage](#-usage)
- [Built with](#️-built-with)
- [Author](#️-author)

## 🔎 Overview

This project represents a **Password Generator** developed using **C#**. This system will allow users to generate secure and random passwords through a console-based application. It offers a variety of configuration options regarding
password length, type of characters used within the password, and the total number of passwords generated.

The system design focuses on providing security by avoiding weaker and repetitive passwords for the user, thus helping them generate unique and un-guessable passwords.

## 📚 Features

- Custom Password Length: Passwords can be chosen within a range of 8 to 20 characters.
- Multiple Passwords: The system allows the creation of multiple passwords at once, as desired.
- Character Options: Uppercase letters, lowercase letters, numerical characters, and symbols are included in the password characters.
- Exclude Confusing Characters: Characters are chosen to avoid visually similar characters, such as "I" and "l", "1", "O", "0", which improve readability.
- Securely Generating Passwords: Cryptographically secure random password generation is done by System.Security.Cryptography.RandomNumberGenerator.
- Console Interface: The interface is simple and easy to use, with no requirement for a graphical interface.

## 📋 Usage

1. - Clone or download the repository.
2. - Open the project in Visual Studio or any other C# integrated development environment.
3. - Build and run the project.
4. - Follow the console's prompts and enter:
- The desired password length
- The number of passwords to create
- The characters that can be used
- Whether characters that can cause confusion are excluded
- The created passwords, as they are displayed in the console
5. - Choose what to do next: continue creating more passwords or exit.
  
No additional installations are required beyond .NET. (Simpler usage available soon?)

## 🛠️ Built with

* [C#](https://en.wikipedia.org/wiki/C_Sharp_(programming_language)) - Programming language
* [.NET](https://en.wikipedia.org/wiki/.NET) - Framework for building and running the console application

## ✒️ Author

* **Tornike Ebralidze** - *Developer and documentation* - [IgnTorn](https://github.com/IgnTorn)


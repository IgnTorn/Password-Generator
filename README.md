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

1. - **Download and extract** one of the ZIP files (choose either the GUI version or the console version) into a folder on your computer.
2. - **Open the folder** and launch the .exe file inside.
3. - **Requirements:** Make sure you have .NET 9 installed on your system.
4. - **Follow the prompts** in the application:
- Enter the desired password length.
- Specify the number of passwords to generate.
- Select the characters that can be used.
- Choose whether to exclude confusing characters.
5. - The program will display the **generated passwords**.
6. - Choose whether to **create more passwords** or **exit**.

No additional installations are required beyond .NET 9.

## 🛠️ Built with

* [C#](https://en.wikipedia.org/wiki/C_Sharp_(programming_language)) - Programming language
* [.NET](https://en.wikipedia.org/wiki/.NET) - Framework for building and running the console application

## ✒️ Author

* **Tornike Ebralidze** - *Developer and documentation* - [IgnTorn](https://github.com/IgnTorn)


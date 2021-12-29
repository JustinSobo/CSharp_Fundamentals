# <--REPO FILE STRUCTURE-->
# Core

    a. C# Syntax.cs
    b. C# Comments.cs
    c. C# Variables.cs
    d. C# Data Types.cs
    e. C# Type Casting.cs
    f. C# User Input.cs
    g. C# Operators.cs
    h. C# Math.cs
    i. C# Strings.cs
    j. C# Booleans.cs
    k. C# If...Else.cs
    l. C# Switch.cs
    m. C# While Loop.cs
    n. C# For Loop.cs
    o. C# Break/Continue.cs
    p. C# Arrays.cs

# Methods
    a. C# Methods.cs
    b. C# Method Parameters.cs
    c. C# Method Overloading.cs

# Classes
    a. C# OOP.cs
    b. C# Classes/Objects.cs
    c. C# Class Members.cs
    d. C# Constructors.cs
    e. C# Access Modifiers.cs
    f. C# Properties.cs
    g. C# Inheritance.cs
    h. C# Polymorphism.cs
    i. C# Abstraction.cs
    j. C# Interface.cs
    k. C# Enums.cs
    l. C# Files.cs
    m. C# Exceptions.cs



# <--C# INTRODUCTION-->
What is C#?
- C# is pronounced "C-Sharp".
- It is an object-oriented programming language created by Microsoft that runs on the .NET Framework.
- C# has roots from the C family, and the language is close to other popular languages like C++ and Java.
- The first version was released in year 2002. The latest version, C# 8, was released in September 2019.

C# is used for:
- Mobile applications
- Desktop applications
- Web applications
- Web services
- Web sites
- Games
- VR
- Database applications
- And much, much more!

Why Use C#?
- It is one of the most popular programming language in the world
- It is easy to learn and simple to use
- It has a huge community support
- C# is an object oriented language which gives a clear structure to programs and allows code to be reused, lowering development costs.
- As C# is close to C, C++ and Java, it makes it easy for programmers to switch to C# or vice versa



# <--MANUALLY CREATE C# PROJECT VIA CLI-->
Microsoft Docs
    - https://docs.microsoft.com/en-us/dotnet/core/introduction

1. Install .NET
    - https://dotnet.microsoft.com/download

2. Confirm Installation
    - dotnet --version

3. Create Project
    - dotnet new console -o app
    - cd app
    - code .

4. Run Project (VS Code)
    - dotnet run

5. Debug (VS Code)
    - Open Command Palette: CTRL + Shift + P
    - Choose: ".NET: Generate Assets for Build and Debug"
    - Choosing this will generate a .vscode folder with a prepopulated build configuration in it.
    - Now go to the “Run and Debug” tab in VSCode, set your breakpoint(s), and click the Play button to debug.

6. Compile Code
    - dotnet build
# chapter two - Processing Data

## Topics

3.1 Reading Input with TextBox Controls
3.2 A First Look at Variables
3.3 Numeric Data Type and Variables
3.4 Performing Calculations
3.5 Inputting and Outputting Numeric Values
3.6 Formatting Numbers with the ToString Method
3.7 Simple Exception Handling
3.8 Using Named Constants

## TextBox Control

A *TextBox* is a Windows Forms control used to allow the user to enter using the keyboard.

It appears as a rectangular input area on the form.

### Main Features

- A TextBox is a rectangular area.
- It can accept keyboard input from the user.
- It is located in the *Common Controls* group of the Toolbox.
- You can double-click the TextBox in the Toolbox to add it to the form.
- The default control name is usually:

  text     .
  textBox1


## Variable Names

Variable Names are the names given to variables in a program.

A variable is used to store data, and the variable name helps us identify and use that data.

There are some rules for variable names. A variable name cannot start with a number, and spaces cannot be used in a variable name.

C# is also case-sensitive, which means uppercase and lowercase letters are treated differently.

Variable names should be clear, meaningful, and easy to understand.

In C#, camelCase is commonly used for variable names.

The main purpose of using good variable names is to make the code clear, organized, and easy to understand.


## Local Variables and Scope

A local variable is a variable that is declared inside a method, block, or specific part of a program.

Local variables can only be used within the area where they are declared.

Scope means the part of the program where a variable can be accessed or used.

For example, if a variable is declared inside a method, its scope is limited to that method.

When the program leaves that area, the local variable can no longer be accessed.

The main purpose of local variables and scope is to control where variables can be used and to keep the program organized and manageable.


## Explicit Conversion with Cast Operators

xplicit conversion is the process of converting a value from one data type to another manually.

It is used when the programmer wants to control the conversion between data types.

A cast operator is used to tell C# which data type we want to convert the value into.

Explicit conversion is commonly used when converting a data type with a larger range or precision into a smaller one.

The main purpose of explicit conversion is to convert data types manually when automatic conversion is not possible.


## What is different Throwing, Catching

Throwing and catching are related to exception handling.

Throwing means intentionally creating or reporting an exception when an error or unexpected situation occurs.

Catching means handling the exception so that the program can respond to the error instead of stopping unexpectedly.

In C#, exceptions are commonly handled using try, catch, and throw.

The main purpose of throwing and catching is to handle errors and keep the program running safely.


 ## Using Named Constants

 A named constant is a value that is given a name and cannot be changed after it is defined.

Constants are used when a value should remain the same throughout the program.

Using named constants makes the code clearer, easier to understand, and easier to maintain.

In C#, the const keyword is used to define a constant.

The main purpose of using named constants is to give fixed values meaningful names and prevent them from being changed accidentally.
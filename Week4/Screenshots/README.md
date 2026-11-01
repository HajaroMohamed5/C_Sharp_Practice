# Using Loops in C#

# C# Loops Examples

This chapter demonstrates how to use **Loop Statements** in C#. Loops allow a program to repeat a block of code multiple times while a condition is true or for a specified number of times.

## Code Explanation

### 1. While Loop

This example demonstrates how to use a `while` loop to repeat code while a condition is true.

```csharp
int number = 1;

while (number <= 5)
{
    MessageBox.Show(number.ToString());
    number++;
}
```

### 2. Increment and Decrement Operators

This example demonstrates how to use `++` to increase a value and `--` to decrease a value.

```csharp
int number = 1;

number++;
MessageBox.Show(number.ToString());

number--;
MessageBox.Show(number.ToString());
```

### 3. For Loop

This example demonstrates how to use a `for` loop to repeat code a specific number of times.

```csharp
for (int i = 1; i <= 5; i++)
{
    MessageBox.Show(i.ToString());
}
```

### 4. Counting Backward

This example demonstrates how to use a `for` loop to count backward from 5 to 1.

```csharp
for (int i = 5; i >= 1; i--)
{
    MessageBox.Show(i.ToString());
}
```

### 5. Do-While Loop

This example demonstrates how to use a `do-while` loop. The code executes at least once before checking the condition.

```csharp
int number = 1;

do
{
    MessageBox.Show(number.ToString());
    number++;
}
while (number <= 5);
```

### 6. Random Numbers

This example demonstrates how to generate a random number using the `Random` class.

```csharp
Random randomNumber = new Random();

int number = randomNumber.Next(1, 11);

MessageBox.Show(number.ToString());
```

## Conclusion

In this chapter, I learned how to use different loop statements in C#, including `while`, `for`, and `do-while`. I also learned about increment and decrement operators and how to generate random numbers.
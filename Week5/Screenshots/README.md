# Using Files in C#

# C# Files Examples

This chapter demonstrates how to work with **File Handling** in C#. Files allow a program to store information, write data, append new data, and read saved information.

## Code Explanation

### 1. Create a File

This example demonstrates how to create a text file using `File.CreateText()`.

```csharp
StreamWriter outputFile;

outputFile = File.CreateText("students.txt");

outputFile.WriteLine("Haajaro");
outputFile.WriteLine("Ahmed");
outputFile.WriteLine("Fatima");

outputFile.Close();

MessageBox.Show("File Created Successfully!");
```

### 2. Write Data to a File

This example demonstrates how to write information into a text file using `StreamWriter`.

```csharp
StreamWriter outputFile;

outputFile = File.CreateText("courses.txt");

outputFile.WriteLine("Computer Science");
outputFile.WriteLine("English");
outputFile.WriteLine("Mathematics");

outputFile.Close();

MessageBox.Show("Data Saved Successfully!");
```

### 3. Append Data to a File

This example demonstrates how to add new information to an existing file using `File.AppendText()`.

```csharp
StreamWriter outputFile;

outputFile = File.AppendText("students.txt");

outputFile.WriteLine("Mohamed");
outputFile.WriteLine("Aisha");

outputFile.Close();

MessageBox.Show("New Data Added!");
```

### 4. Read Data from a File

This example demonstrates how to read information from a text file using `StreamReader` and `ReadLine()`.

```csharp
StreamReader inputFile;

inputFile = File.OpenText("students.txt");

string name1 = inputFile.ReadLine();
string name2 = inputFile.ReadLine();

inputFile.Close();

MessageBox.Show(name1 + "\n" + name2);
```

### 5. Reading a File with a Loop

This example demonstrates how to use a `while` loop and `EndOfStream` to read all lines from a file.

```csharp
StreamReader inputFile;

inputFile = File.OpenText("students.txt");

while (!inputFile.EndOfStream)
{
    string line = inputFile.ReadLine();
    MessageBox.Show(line);
}

inputFile.Close();
```

### 6. OpenFileDialog

This example demonstrates how to use the `OpenFileDialog` control to select and open a text file.

```csharp
private void btnOpen_Click(object sender, EventArgs e)
{
    if (openFileDialog1.ShowDialog() == DialogResult.OK)
    {
        StreamReader inputFile;

        inputFile = File.OpenText(openFileDialog1.FileName);

        string data = inputFile.ReadToEnd();

        inputFile.Close();

        MessageBox.Show(data);
    }
}
```

### 7. SaveFileDialog

This example demonstrates how to use the `SaveFileDialog` control to save information into a text file.

```csharp
private void btnSave_Click(object sender, EventArgs e)
{
    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
    {
        StreamWriter outputFile;

        outputFile = File.CreateText(saveFileDialog1.FileName);

        outputFile.WriteLine("Welcome to C# Files");

        outputFile.Close();

        MessageBox.Show("File Saved Successfully!");
    }
}
```

## Conclusion

In this chapter, I learned how to work with files in C#. I practiced creating files, writing data, appending information, and reading files using `StreamReader`. I also learned how to use `OpenFileDialog` and `SaveFileDialog` controls.
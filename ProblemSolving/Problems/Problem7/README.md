## Problem 7: Reverse a String

### Problem Overview

Write a C# method that takes a string as input and returns a new string that is the reverse of the original. This problem is useful for practicing string manipulation and understanding how to work with character arrays.

### Core Concepts

- String manipulation
- Character arrays
- Looping in reverse
- Building strings manually

### Algorithm Steps

1. Convert the input string into a character array using `ToCharArray()`.
2. Initialize an empty string to store the reversed result.
3. Loop through the array from the last character to the first.
4. Append each character to the result string.
5. Return the final reversed string.

### Example

```csharp
Input:  "hello"
Output: "olleh"

### Code

```csharp
static string Reverse(string name)
{
    char[] chars = name.ToCharArray();  // Convert string into array of chars
    string reversed = "";

    for (int i = name.Length - 1; i >= 0; i--)
    {
        reversed += chars[i];
    }

    return reversed;
}

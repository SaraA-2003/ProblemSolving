# Problem 7: Reverse a String

## Overview  
This problem requires implementing a method that takes a string input and returns the reversed version of that string. The reversal should be done manually by iterating through the string from the end to the beginning, without using built-in reverse methods.

## Requirements  
- Given a string, return a new string which is the reverse of the input.  
- Do not use built-in methods like `Array.Reverse()` or `String.Reverse()`.  
- Handle all characters including spaces and special symbols.

## Algorithm  
The algorithm follows these steps:

- Convert the input string into a character array.  
- Initialize an empty string `reversed` to hold the reversed characters.  
- Iterate through the character array starting from the last index down to the first.  
- Append each character to `reversed`.  
- Return the `reversed` string after the loop ends.

Time complexity: **O(n)**  
Space complexity: **O(n)**

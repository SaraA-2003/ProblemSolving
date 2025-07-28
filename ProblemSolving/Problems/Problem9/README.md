# Problem 9: Check If String Contains Only Digits

## Overview  
This problem requires implementing a method that checks whether a given string consists only of numeric digit characters (`0` through `9`). The method should return `true` if all characters are digits and `false` otherwise.

## Requirements  
- Given a string, verify if every character is a digit from `0` to `9`.  
- If any character is not a digit, return `false`.  
- An empty string can be considered as not containing only digits (optional based on requirement).

## Algorithm  
The algorithm follows these steps:

- Iterate over each character in the string.  
- For each character, check if it falls between `'0'` and `'9'` (inclusive).  
- If a character is outside this range, immediately return `false`.  
- If the loop completes without finding a non-digit character, return `true`.

Time complexity: **O(n)**  
Space complexity: **O(1)**

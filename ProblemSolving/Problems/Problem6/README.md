# Problem 6: Count Vowels in a String

## Overview
This problem requires implementing a method that counts how many vowels (`a`, `e`, `i`, `o`, `u`) are present in a given string. The solution must account for both uppercase and lowercase letters and ignore spaces or other non-vowel characters.

## Requirements
- Given a string, count the number of vowels it contains.
- Vowels to consider: `a`, `e`, `i`, `o`, `u` (case-insensitive).
- Ignore spaces and non-vowel characters.
- Do not use any built-in methods for counting or filtering.

## Algorithm
The algorithm follows these steps:

- Convert the entire input string to lowercase to ensure case-insensitivity.
- Initialize a counter variable `count` to `0`.
- Iterate over each character in the string.
  - If the character is a space, skip it.
  - If the character is a vowel (`a`, `e`, `i`, `o`, `u`), increment the counter.
- Return the final count after traversing the string.

Time complexity: **O(n)**  
Space complexity: **O(1)**

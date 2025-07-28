# Problem 2: First Non-Repeated Character

## Overview

This problem focuses on finding the **first non-repeated character** in a string using **C#** and **Visual Studio**. Two solutions are demonstrated:
- A **brute-force approach** using nested loops
- An optimized approach using a **dictionary** to count character frequency

The program also handles edge cases such as an empty string.


## Problem Statement

Given a string, return the **first character** that does **not repeat**.  
If all characters are repeated, return a default value (`'\0'` or `'!'` depending on the method used).


## Solutions

### Optimized Solution Using Dictionary

This version uses a `Dictionary<char, int>` to count the frequency of each character, then iterates again to find the first with count 1.



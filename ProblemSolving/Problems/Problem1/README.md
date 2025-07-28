# Problem 1: Second Largest Number

## Overview

This problem focuses on finding the **second largest number** in an integer array using **C#** and **Visual Studio**.

The solution also handles edge cases such as:
- An empty array
- An array with only one element

## Algorithm

The algorithm loops through the array once and keeps track of:
- `max`: the current largest number
- `secondMax`: the current second largest number

If a new maximum is found, `secondMax` is updated to the previous `max`.



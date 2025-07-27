# Problem 3: Find the Missing Number

## Overview

This problem focuses on finding a **missing number** in an array containing `n-1` distinct integers from `1` to `n`.  
The solution is implemented in **C#** using **Visual Studio**.

The approach uses a simple mathematical formula to calculate the expected total of numbers from `1` to `n`, then subtracts the actual sum of the array to identify the missing value.


## Problem Statement

Given an array of length `n-1` containing distinct integers from `1` to `n` (with one number missing), return the missing number.



## Algorithm

The algorithm is based on the formula for the sum of the first `k` natural numbers:
`Sum = k * (k + 1) / 2`

- `k` is the total count of expected elements: `array.Length + 1`
- Subtract the sum of actual elements from the expected total to find the missing number.


## Code Summary

```csharp
static int missingNumber(int[] num)
{
    int k = num.Length + 1; // total expected elements
    int realTotal = k * (k + 1) / 2;

    int total = 0;
    for (int i = 0; i < num.Length; i++)
    {
        total += num[i];
    }

    return realTotal - total;
}

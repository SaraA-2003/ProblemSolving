# Problem 5: Find the Maximum Value in an Array

## Overview
This problem requires implementing a method that returns the maximum value from a given array of integers. The method should manually determine the largest value without using any built-in functions such as `Max()`.

## Requirements
- Given an integer array, return the highest value in the array.
- Do not use built-in methods like `Array.Max()` or LINQ.
- Use basic control structures to achieve the result.

## Algorithm
The solution uses a linear search to find the maximum value:

- Initialize a variable `max` to the first element of the array.
- Iterate through the array.
- For each element, compare it to `max`.
  - If the current element is greater than `max`, update `max`.
- After the loop ends, return the `max` value.

Time complexity: **O(n)**  
Space complexity: **O(1)**

## Code
```csharp
static int maxNum(int[] numbers)
{
    int max = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (max < numbers[i])
        {
            max = numbers[i];
        }
    }
    return max;
}

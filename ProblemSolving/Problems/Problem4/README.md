# Problem 4: Sort an Array Without Built-in Methods

## Overview
This problem requires implementing a method that sorts an array of integers in ascending order without using any built-in sorting functions. The goal is to manually perform the sorting logic using basic control structures.

## Requirements
- Sort an integer array in ascending order.
- Do not use built-in methods such as `Array.Sort()`, LINQ functions, or other helper utilities.
- The algorithm must be implemented using loops and conditional statements.

## Algorithm
The solution uses a simple selection-sort-like technique. The algorithm compares each element with the elements that follow it, and if a smaller value is found, it swaps the two elements.

- Iterate through each element of the array.
- For each element, compare it with the rest of the array.
- Swap if a smaller element is found.
- Continue this process until the array is sorted.

Time complexity: **O(n²)**  
Space complexity: **O(1)** (in-place sorting)

## Code
```csharp
static int[] sort(int[] numbers)
{
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        for (int j = i; j < numbers.Length; j++)
        {
            if (numbers[i] >= numbers[j])
            {
                int temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;
            }
        }
    }
    return numbers;
}

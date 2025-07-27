## Problem 4: Sort an Array in Ascending Order

### 🔧 Description
Implement a method that **sorts an array of integers in ascending order** without using any built-in sorting methods (e.g., `Array.Sort()`).

### 🧠 Algorithm Used
A simple **selection sort** is used. The algorithm goes through the array and, in each iteration, places the smallest unsorted element in its correct position by swapping it.

### 🧮 Code Implementation
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

# Problem 13: Binary Search (Recursive)

## Overview  
This problem requires implementing the binary search algorithm using recursion to find the index of a target value in a sorted integer array. The method returns the index of the target if found, or -1 if not found.

## Requirements  
- Given a sorted array and a target value, recursively search for the target’s index.  
- Return the index if found; otherwise, return -1.  
- Use recursion to divide the search space.  
- Time complexity should be O(log n).

## Algorithm  
The algorithm follows these steps:

- Check the base case: if `left` index exceeds `right`, return -1 (target not found).  
- Calculate the middle index `mid` between `left` and `right`.  
- If the element at `mid` equals the target, return `mid`.  
- If the target is less than the element at `mid`, recursively search the left subarray (`left` to `mid - 1`).  
- Otherwise, recursively search the right subarray (`mid + 1` to `right`).

Time complexity: **O(log n)**  
Space complexity: **O(log n)** due to recursion stack.

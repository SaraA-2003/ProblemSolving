# Problem 8: Merge Two Sorted Arrays

## Overview  
This problem requires implementing a method that merges two sorted arrays of integers into a single sorted array. The input arrays are assumed to be sorted in ascending order, and the output array should maintain this order.

## Requirements  
- Given two sorted integer arrays, merge them into one sorted array.  
- Do not use built-in sorting methods on the combined array.  
- Handle cases where one or both arrays are empty.

## Algorithm  
The algorithm follows these steps:

- Initialize pointers (indices) for both arrays and a pointer for the result array.  
- Compare the elements at the pointers of both arrays.  
- Append the smaller element to the result array and move the corresponding pointer forward.  
- Repeat the process until one of the arrays is fully traversed.  
- Append any remaining elements from the other array to the result array.  
- Return the merged sorted array.

Time complexity: **O(n + m)**, where `n` and `m` are the lengths of the two input arrays.  
Space complexity: **O(n + m)**

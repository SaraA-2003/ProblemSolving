# Problem 12: Binary Search (Iterative)

## Overview  
This problem requires implementing the binary search algorithm iteratively to find the index of a target value in a sorted integer array. If the target is found, return its index; otherwise, return -1.

## Requirements  
- Given a sorted array of integers and a target value, find the index of the target using an iterative approach.  
- Return the index if found, otherwise return -1.  
- The algorithm should run in O(log n) time complexity.

## Algorithm  
The algorithm follows these steps:

- Initialize two pointers: `left` at the start and `right` at the end of the array.  
- While `left` is less than or equal to `right`:  
  - Calculate `mid` as the middle index between `left` and `right`.  
  - If the element at `mid` equals the target, return `mid`.  
  - If the target is greater than the element at `mid`, move `left` to `mid + 1`.  
  - If the target is less than the element at `mid`, move `right` to `mid - 1`.  
- If the loop ends without finding the target, return -1.

Time complexity: **O(log n)**  
Space complexity: **O(1)**

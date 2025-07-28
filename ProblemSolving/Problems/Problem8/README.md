## Problem 8: Merge Two Sorted Arrays

### Description

This program defines a method that merges two **sorted integer arrays** into a single sorted array. It assumes the input arrays are already sorted in ascending order and combines them in order.

### Approach

- Get the lengths of the two arrays.
- Handle edge cases: if one of the arrays is empty, return the other.
- Use three pointers:
  - `i` for iterating array `a`
  - `j` for iterating array `b`
  - `k` for building the merged result
- Compare elements from both arrays and insert the smaller one into the result.
- Append any remaining elements after one array is fully traversed.


# Problem 11: Find All Subsets of a Given Set (Recursion)

## Overview  
This problem requires generating all possible subsets (the power set) of a given set of integers using recursion. The solution explores including or excluding each element and builds subsets step by step.

## Requirements  
- Given an integer array, find all possible subsets including the empty set.  
- Use recursion to explore all combinations.  
- Return a list of lists representing all subsets.  
- Preserve the order of elements in subsets as per their original appearance.

## Algorithm  
The algorithm follows these steps:

- Start with an empty temporary list `temp` to hold the current subset.  
- Add the current subset (`temp`) to the result list.  
- Iterate over the elements starting from the current index:  
  - Include the current element in `temp`.  
  - Recursively call the function with the next index.  
  - Backtrack by removing the last added element from `temp`.  
- Continue until all elements have been processed.

Time complexity: **O(2^n)** due to all subset combinations.  
Space complexity: **O(n)** for recursion stack and temporary storage.

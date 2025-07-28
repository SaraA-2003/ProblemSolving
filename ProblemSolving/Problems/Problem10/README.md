# Problem 10: Multithreaded Prime Number Finder

## Overview  
This problem involves finding all prime numbers between 1 and 1,000,000 using multiple threads asynchronously. The goal is to utilize C#’s `async` and `Task` features to efficiently split the workload across several threads and speed up computation.

## Requirements  
- Use multiple asynchronous tasks to divide the range from 1 to 1,000,000.  
- Each task checks for prime numbers in its assigned sub-range.  
- Combine the results from all tasks into a single list of prime numbers.  
- Use the `async/await` pattern to handle asynchronous execution.

## Algorithm  
The algorithm follows these steps:

- Define the total range (1 to 1,000,000) and number of threads/tasks to run concurrently.  
- Split the range into approximately equal sub-ranges, one per task.  
- Create and start asynchronous tasks, each generating prime numbers within its sub-range.  
- Use `Task.WhenAll` to wait for all tasks to complete and gather their results.  
- Merge all prime number lists from each task into a single list.  
- Return or output the combined list and its count.

Time complexity: Approximately **O(n√n / T)** where `T` is the number of tasks (threads).  
Space complexity: **O(n)** for storing prime numbers found.



### Optional Notes  
- The prime checking function `isPrime` uses an optimized approach checking divisibility up to the square root of the number and skipping even numbers after 2.  
- Increasing the number of tasks can improve performance but with overhead from task creation and synchronization.


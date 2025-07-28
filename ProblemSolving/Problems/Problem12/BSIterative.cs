using System;
using System.Collections.Generic;
using System.Linq;


namespace Problems.Problem12
{
    internal class BSIterative
    {

        public static void Run()
        {
            int[] numbers = {};
            if (numbers.Length == 0)
            {
                Console.WriteLine("The array of numbers is empty");
            }
            else
            {
                Console.WriteLine("Enter the target number to check if it is exist: ");
                int target = Convert.ToInt32(Console.ReadLine());
                int index = binarySearchIterative(numbers, target);
                if (index < 0)
                    Console.WriteLine($"False,number {target} doesnot exit");
                else
                    Console.WriteLine($"True, number {target} does exist at index: {index}");

            }
        }

        static int binarySearchIterative(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;
            while (left <= right) 
            {
                int mid =(left + right) / 2;

                if (numbers[mid] == target)
                {
                    return mid;
                }
                else if (target > numbers[mid])
                {
                    left = mid + 1;
                }
                else if (target < numbers[mid])
                {
                    right = mid - 1;
                }  
            }
            return -1;
        }
    }
}

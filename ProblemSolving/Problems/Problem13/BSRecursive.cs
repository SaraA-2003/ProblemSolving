using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problem13
{
    internal class BSRecursive
    {
        public static void Run()
        {
            int[] numbers = { 1, 2, 3, 7, 8, 12 };
            if (numbers.Length == 0)
            {
                Console.WriteLine("The array of numbers is empty");
            }
            else
            {


                int left = 0;
                int right = numbers.Length - 1;
                Console.WriteLine("Enter the target number to check if it is exist: ");
                int target = Convert.ToInt32(Console.ReadLine());

                int index = binarsearchSRecursive(numbers, target, left, right);

                if (index < 0)
                    Console.WriteLine($"False,number {target} doesnot exit");
                else
                    Console.WriteLine($"True, number {target} does exist at index: {index}");

            }
        }

        static int binarsearchSRecursive(int[] numbers, int target, int left, int right)
        {

            if (left > right)
                return -1;
            int mid = (left + right) / 2;
            if (numbers[mid] == target)
            {
                return mid;
            }
            else if (target < numbers[mid])
            {

                return binarsearchSRecursive(numbers, target, left, mid-1);
            }
            else 
            {

                return binarsearchSRecursive(numbers, target, mid+1, right);


            }

        }
    }
}

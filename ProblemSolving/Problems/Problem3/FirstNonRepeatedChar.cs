// See https://aka.ms/new-console-template for more information
using System.Collections.Immutable;
/*
 * array of N-1 integers from 1 to N
 * so the array will be missing one number so we can use th sum of the first k number formula 
 * sum = k (k+1)/2 
 * to achive that we first we need the real length of the array without missing the number so it will be the length
 * of the N-1 array +1 , then by the formula we will calculate the summation of the array including the missing number 
 * becuse the range will be from (1 to N ) by the formula
 * then we calculate summation from the provided array 
 * The result from the  difference between the summation from the formula and the one from the provided array
 * will be the missing number
 * 
 * */

namespace Problems.Problem3
{

    class Program3
    {
        public static void Run()
        {

            int[] number = { 1, 2, 3, 5 };

            if (number.Length == 0)
            {
                Console.WriteLine("The array is empty");
            }
            else
            {
                Console.WriteLine("The numbers are: ");
                foreach (int i in number)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine("\nThe missing number is: " + missingNumber(number));
            }
        }

        static int missingNumber(int[] num)
        {

            int k = num.Length + 1; // the array have missing number so we must add +1 to the length so we can perform th esum formula of the first k numbers
            int realTotal = k * (k + 1) / 2;
            int total = 0;
            for (int i = 0; i < num.Length; i++)
            {
                total += num[i];
            }

            return realTotal - total;
        }
    }
}

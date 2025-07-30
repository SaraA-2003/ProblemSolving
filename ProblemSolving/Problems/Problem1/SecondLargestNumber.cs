// See https://aka.ms/new-console-template for more information

namespace Problems.Problem1
{
    class Program1
    {
        static int? FindSecondLargestNumber(int[] num)
        {
            int max = int.MinValue;
            int secondMax = int.MinValue;

            foreach (int value in num)
            {
                if (value > max)
                {
                    secondMax = max;
                    max = value;
                }
                else if (value > secondMax && value != max)
                {
                    secondMax = value;
                }
            }

            // If secondMax was never updated, it means no valid second max exists
            return secondMax == int.MinValue ? (int?)null : secondMax;
        }

        public static void Run()
        {
            int[] numbers = { 5, 5, 5 }; // Example array

            if (numbers.Length == 0)
            {
                Console.WriteLine("Error: The array is empty.");
            }
            else if (numbers.Length == 1)
            {
                Console.WriteLine("There is only one number, so there is no second max number.");
            }
            else
            {
                int? secondMax = FindSecondLargestNumber(numbers);
                if (secondMax == null)
                {
                    Console.WriteLine("No valid second max number found (all elements are the same).");
                }
                else
                {
                    Console.WriteLine($"The second max number is {secondMax}");
                }
            }
        }
    }
}

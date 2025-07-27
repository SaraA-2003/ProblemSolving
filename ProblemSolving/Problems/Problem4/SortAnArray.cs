// See https://aka.ms/new-console-template for more information

namespace Problems.Problem4
{
    class Program4
    {
        public static void Run()
        {

            int[] numbers = { 9, 5, 2, 1, 0 };


            if (numbers.Length == 0)
            {
                Console.WriteLine("Empty Array, can't be sort");
            }
            else if (numbers.Length == 1)
            {
                Console.WriteLine("Array contains only one number");
            }
            else
            {
                Console.WriteLine("Before Sorting: ");
                foreach (int number in numbers)
                {

                    Console.Write($"{number} ");
                }
                Console.WriteLine("\nSorted array: ");
                int[] sorted = sort(numbers);
                foreach (int number in sorted)
                {

                    Console.Write($"{number} ");
                }
            }

        }// end of main method

        static int[] sort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i] >= numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            return numbers;


        }// end of sort



    }// end of classs
}
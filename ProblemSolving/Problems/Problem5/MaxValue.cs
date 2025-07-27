// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        
        int[] numbers = {5,9,1,0,4,9};
        if (numbers.Length == 0)
        {
            Console.WriteLine("The array is empty");

        }
        else if (numbers.Length == 1)
        {
            Console.WriteLine("The array contains only one number");
        }
        else
        {
            Console.WriteLine("The array is: ");
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
            int max = maxNum(numbers);

            Console.WriteLine($"\nThe max number is: {max}");
        }

    }//end of main


    static int maxNum(int[] numbers)
    {
        int max = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (max < numbers[i])
            {
                max = numbers[i];
            }

        }
        return max;
    }// end of method
}// end of class

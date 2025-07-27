// See https://aka.ms/new-console-template for more information


class Programm
{

    static int findSecondLargestNumber(int[] num)
    {
        int secondMax =0;
        int max = num[0];

        for (int i = 0; i < num.Length; i++)
        {
            if (max < num[i])
            {
                secondMax = max;
                max = num[i];
            }
        }

        return secondMax;
    }
    static void Main ()
    {

        int[] numbers = {1};
        if (numbers.Length == 0)
        {
            Console.WriteLine("Error: the array is empty");

        }
        else if (numbers.Length == 1)
        {
            Console.WriteLine("There is only one number, so there is not second max number");
        }
        else
        {
            int secondMax = findSecondLargestNumber(numbers);
            Console.WriteLine($"the second max number is {secondMax}");

        }


    }

   


}



using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problem11
{
    internal class Subsets
    {
        public static void Run()
        {
            int[] numbers = { 1, 2, 3, 4 };
            if (numbers.Length == 0)
                Console.WriteLine("The array is empty. No subsets");
            else
            {
                List<List<int>> result = new List<List<int>>();
                result = findSubsets(result, numbers, new List<int>(), 0);
                foreach (var list in result)
                {
                    Console.Write("[");
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.Write(list[i]);
                        if (i < list.Count - 1)
                            Console.Write(", ");
                    }
                    Console.WriteLine("]");


                }
            }
        }


        static List<List<int>> findSubsets(List<List<int>> result, int[] numbers, List<int> temp, int index)
        {
            //temp is empty so firts we will add {}
            result.Add(new List<int>(temp));
            for (int i = index; i < numbers.Length; i++)
            {

                temp.Add(numbers[i]);
                findSubsets(result, numbers, temp, i + 1);
                temp.RemoveAt(temp.Count - 1);

            }
            return result;

        }
    }
}

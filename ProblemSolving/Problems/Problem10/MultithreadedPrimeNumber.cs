using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problem10
{
     internal class MultithreadedPrimeNumber
    {
        public static async Task Run()

        {


            int max = 1000000;
            int numOfThreads = 5;
            int group = max / numOfThreads;
            //declare list of tasks and each task return list of int (prime numbers)
            List<Task<List<int>>> tasks = new List<Task<List<int>>>();


            //create num of threads tasks and each task have a range
            for (int i = 0; i < numOfThreads; i++)
            {
                int start = i * group + 1;

                int end = 0;

                if (i == numOfThreads - 1)
                    end = max;
                else
                    end = start + group - 1;

                tasks.Add(createTaskOfPrimeNumbers(start, end));


            }


            // return array of tasks
            var Temp = await Task.WhenAll(tasks);// wait for all the tasks to finish
            Console.Write("hello");
            // Combine all the lists to print them
            List<int> PrimeNumbers = new List<int>();
            foreach (var primes in Temp)
                PrimeNumbers.AddRange(primes);



            // Output or use the result
            Console.WriteLine($"Total primes found: {PrimeNumbers.Count}");

        }

        static async Task<List<int>> createTaskOfPrimeNumbers(int start, int end)
        {

            return await Task.Run(() =>
            {

                List<int> primeNumbers = new List<int>();
                for (int i = start; i <= end; i++)
                {
                    if (isPrime(i) == true)
                        primeNumbers.Add(i);


                }


                return primeNumbers;
            });
        }




        static bool isPrime(int number)
        {

            if (number < 2)
                return false;
            if (number == 2)
                return true;
            if (number % 2 == 0)
                return false;
            int range = (int)Math.Sqrt(number);
            for (int i = 3; i <= range; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }



            }
            return true;
        }// end of method

    }// endo of class

}

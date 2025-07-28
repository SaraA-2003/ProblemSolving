using System;
using Problems.Problem1;

using Problems.Problem2;
using Problems.Problem3;
using Problems.Problem4;
using Problems.Problem5;
using Problems.Problem6;
using Problems.Problem7;
using Problems.Problem8;
using Problems.Problem9;
using Problems.Problem10;

namespace ProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call the solution you want to run
            //Program1.Run();
            //Program2.Run();
            //Program3.Run();
            //Program4.Run();
            //Program5.Run();
            //Program6.Run();
            //ReverseAString.Run();
            //MergeTwoSortedArrays.Run();
            //OnlyDigitString.Run();
            
           Task task =  MultithreadedPrimeNumber.Run();
        }
    }
}

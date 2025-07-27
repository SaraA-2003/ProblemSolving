using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problem9
{
    internal class OnlyDigitString
    {
        public static void Run()
        {
            string number = "125776";
            if (number.Length == 0)
            {
                Console.WriteLine("String is empty");

            }
            else
            {
                bool allDigit = CheckOnlyDigit(number);
                Console.WriteLine("Does the string conatin only numaric numbers? " + allDigit);
            }
        }//end or run


        static bool CheckOnlyDigit(string str)
        {
            int flag = 0;
            foreach(char s in str)
            {
                if (s >= '0' && s <= '9')
                {
                    continue;
                }

                return false;

            }

           return true;

        }
    }//end of class
}// end of namespace

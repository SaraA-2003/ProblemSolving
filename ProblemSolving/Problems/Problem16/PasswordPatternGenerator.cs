using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.Problem16
{
    internal class PasswordPatternGenerator
    {
        static char[] lower = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        static char[] upper = "ABCDEFGHIGKLMNOPQRSTUVWXYZ".ToCharArray();
        static char[] digits = "0123456789".ToCharArray();
        static char[] symboles = "!@#$%^&*".ToCharArray();
        public static void Run()
        {
            
            string pattern = "Ax#";
            if (pattern.Length == 0)
            {
                Console.WriteLine("The string is empty");

            }
            else
            {
                int count = 0;
                List<string> patterns = generatePassword(pattern);
                foreach (string s in patterns)
                {
                    Console.WriteLine(s);
                    count++;
                    if (count > 100)
                    {
                        Console.WriteLine("I print only the first 100 combination of the password becuse it will be too long to print the rest");
                        break;
                    }
                }
            }
        }//end of function

        static List<string> generatePassword(string pattern)
        {
            List<string> result = new List<string>();
            generateRecursion(pattern, 0, "", result);
            return result;
        }//end of function

        static void generateRecursion(string pattern , int pos , string temp , List<string> result)
        {
            //Base case 
            //here pos is the index of the pattern string , so we can track the pattern
            if (pattern.Length == pos)
            {
                result.Add(temp);
                return;// we have to put it so it will return backwrords after the the base is reached
            }

            char[] chosen;
            char p = pattern[pos];//to store the current pattern syntax
            //based on thw
            switch (p)
            {
                case 'a':
                    chosen = lower;
                    break;
                case 'A':
                    chosen = upper;
                    break;
                case '#':
                    chosen = digits;
                    break;
                case '*':
                    chosen = symboles;
                    break;
                default:
                    chosen = new char[] { p }; //something else than a,A,#,* will be fixed 
                    break;
            }
            foreach (char c in chosen)
             {
                /* by doing temp + c : we will save the current chosen char to temp and by that
                 * we will store the cobination passowrd that is created to add it to the list.
                 * pos +1 : will ensure that we will see al, the password wanted pattern (the char)
                 */
                generateRecursion(pattern, pos+1, temp + c, result); 
             }

            
        }//end function




    }
}

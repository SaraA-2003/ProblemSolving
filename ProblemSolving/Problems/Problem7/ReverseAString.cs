using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problem7
{
    internal class ReverseAString
    {

        public static void Run()
        {

            string name = "Hello Sara";
            if (name.Length == 0)
            {
                Console.WriteLine("The string is empty");

            }
            else if (name.Length == 1)
            {
                Console.WriteLine("There is only one char");

            }
            else
            {

                Console.WriteLine("the string is: "+name);
                string reversed = Reverse(name);
                Console.WriteLine("the reversed string is: " + reversed);
            }


        }

        static string Reverse(string name)
        {
            char[] chars = name.ToCharArray();// convert string into array of chars
            string reversed = "";
            for (int i = name.Length -1; i >= 0; i--)
            {
                reversed += chars[i];

            }
            return reversed;
        }
    }
}

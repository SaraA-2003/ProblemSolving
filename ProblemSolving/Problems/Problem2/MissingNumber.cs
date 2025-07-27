// See https://aka.ms/new-console-template for more information

/*
class Program2
{
    static char findFirstUnrepeatedChar(string str)

    {
     
        int flag = 0;

        for (int i = 0; i < str.Length; i++)
        {
            flag = 0;
            for (int j = 0; j < str.Length; j++)
            {
                if (str[i] == str[j] && i != j)
                {
                    flag = 1;
                    break;

                }
               
            }

            if (flag == 0)
            {
                return str[i];
            }
        }

        return '!';
    }
    static void Main2()
    {
        string name = "aabbc";
        if (name.Length == 0) {
            Console.WriteLine("Empty string");
        }
        else{
            string newName = name.ToLower();
            Console.WriteLine(newName);
            char n = findFirstUnrepeatedChar(newName);
            Console.WriteLine(n);
        }
    }
}
*/

//using dicitionary 


namespace Problems.Problem2
{
    class Program2
    {
       public static void Run()
        {
            string name = "aabbcdd";
            char c = nonRepeatedChar(name);
            Console.WriteLine(c);

        }


        static char nonRepeatedChar(string name)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < name.Length; i++)
            {
                char c = name[i]; //key  
                if (dic.ContainsKey(c))
                {
                    dic[c]++;//value ++

                }
                else
                {
                    dic.Add(c, 1);
                }

            }

            for (int i = 0; i < name.Length; i++)
            {
                char c = name[i];
                if (dic[c] == 1 && dic.ContainsKey(c))
                {
                    return c;
                }
            }

            return '\0';
        }

    }
}
// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        string sent = "b";
        if (sent.Length == 0)
        {
            Console.WriteLine("Empty string");
        }
        else
        {
            int count = countVowels(sent);
            Console.WriteLine($"The string is: {sent}");
            if (count > 0)
            {
                Console.WriteLine("The count of vowels that the sentence contains are: " + count);
            }
            else
            {
                Console.WriteLine("Does not contain vowels");
            }
        }
    }

    static int countVowels (string name)
    {
        int count = 0;
       string sent = name.ToLower();
        foreach (char c in sent)
        {
            if (c == ' ')
            {
                continue;
            }
            if (c == 'a' || c == 'e' || c == 'o' || c == 'i' || c == 'u')
            {
                count++;
            }
        }
        return count;
    }//end of method
}

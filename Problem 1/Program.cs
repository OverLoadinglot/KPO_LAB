using System;
using System.Linq;
 
class Program
{
    static void Main(string[] args)
    {
        string word = Console.ReadLine();
        string result = "";
        string withoutFirst = word.Substring(1);
 
        if (word.All(char.IsUpper))
        {
            foreach (char c in word)
            {
                result += char.ToLower(c);
            }
 
            Console.WriteLine(result);
        }
        else if (withoutFirst.All(char.IsUpper))
        {
            result += char.ToUpper(word[0]);
 
            foreach (char c in withoutFirst)
            {
                result += char.ToLower(c);
            }
 
            Console.WriteLine(result);
        }
        else
        {
            Console.Write(word);
        }
    }
}
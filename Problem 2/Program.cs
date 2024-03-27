using System;
using System.Linq;
using System.Collections.Generic;
 
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int WordsNumber = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, int> archive = new Dictionary<string, int>();
 
            for (int i = 0; i < WordsNumber; i++)
            {
                string a = Console.ReadLine();
                if (archive.ContainsKey(a))
                {
                    Console.WriteLine($"{a}{archive[a]}");
                    archive[a] += 1;
                }
                else
                {
                    Console.WriteLine("OK");
                    archive[a] = 1;
                }
            }
        }
    }
}
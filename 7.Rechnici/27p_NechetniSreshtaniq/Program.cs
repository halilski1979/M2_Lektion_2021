using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27p_NechetniSreshtaniq
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split(' ').ToList();
            Dictionary<string, int> wordsCounter = new Dictionary<string, int>();
            foreach (var item in words)
            {
                if (wordsCounter.ContainsKey(item))
                {
                    wordsCounter[item]++;                   

                }
                else
                {
                    wordsCounter[item] = 1;
                }
            }
            foreach (var item in wordsCounter)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }

            foreach (var item in wordsCounter)
            {
                if (item.Value%2!=0)
                {
                    Console.Write($"{item.Key}, ");
                }
            }
        }
    }
}

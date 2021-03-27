using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28p_SreshtaniqChislo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var counts = new SortedDictionary<double, int>();
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            foreach (var item in nums)
            {
                if (counts.ContainsKey(item))
                {
                    counts[item]++;
                }
                else
                {
                    counts[item] = 1;
                }
            }

            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }

        }
    }
}

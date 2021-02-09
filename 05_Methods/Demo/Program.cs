using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            string first = Console.ReadLine();
            string second = Console.ReadLine();
            //string max = GetMax(first, second);
            //Console.WriteLine(max);
            if (first.CompareTo(second) >= 0)
            {
                Console.WriteLine(first); 
            }
            else
            {
                Console.WriteLine(first);
            }
        }
    }
}

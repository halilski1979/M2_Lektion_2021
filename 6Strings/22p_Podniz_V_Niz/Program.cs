using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22p_Podniz_V_Niz
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();
            int counter = 0;
            int index = input.IndexOf(pattern);

            //Console.WriteLine(index);
            while (index!=-1)
            {
                counter++;
                index = input.IndexOf(pattern,index+1);
            }
            Console.WriteLine(counter);

        }
    }
}

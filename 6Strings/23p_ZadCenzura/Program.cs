using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23p_ZadCenzura
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] censura = Console.ReadLine().Split(' ').ToArray();
            string words = Console.ReadLine();

            foreach (var item in censura)
            {
                if (words.Contains(item))
                {
                    words = words.Replace(item,new string('*', item.Length));
                }
            }
            Console.WriteLine(words);

        }
    }
}

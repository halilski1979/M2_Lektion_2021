using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ZnakCqloChislo
{
    class Program
    {
        static void Znak(int n)

        {
            //n = int.Parse(Console.ReadLine());
            if (n>0)
            {
                Console.WriteLine("Polojitelno");
            }
            else if (n<0)
            {
                Console.WriteLine("Otricatelno");
            }
            else
            {
                Console.WriteLine("Nula");
            }
        }

        static void Main(string[] args)
        {
            int nn = int.Parse(Console.ReadLine());
            Znak(nn);
        }
    }
}

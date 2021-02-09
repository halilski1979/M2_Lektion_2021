using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001.AddOne_PlusIOne
{
    class Program
    {
        //Разликата между void  и тип, връщан от метода
        static void addOne(int n)
        {
            n++;
            Console.WriteLine(n);
        }

        static int PlusDve(int n)
        {
            return n + 1;
        }

        static void Main(string[] args)
        {
            int par = int.Parse(Console.ReadLine());
            addOne(par);
            Console.WriteLine(PlusDve(par));

            //int sum = addOne(par);
            int sum1 = PlusDve(par);
        }
    }
}

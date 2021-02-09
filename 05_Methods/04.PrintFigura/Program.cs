using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PrintFigura
{
    class Program
    {
        static void printHeadFoot(int n)
        {
            Console.WriteLine(new string('-',2*n));
        }
        static void printMiddle(int n)
        {
            for (int i = 0; i <n-2; i++)
            {
                Console.Write("-");
                for (int j = 0; j < n-1; j++)
                {
                    
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        } 
        
        static void printAll(int n)
        {
            printHeadFoot(n);
            printMiddle(n);
            printHeadFoot(n);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            printAll(n);
        }
    }
}

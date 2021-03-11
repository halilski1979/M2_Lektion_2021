using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001.DemoFirst1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] B = {2,3,4,11,15};

            int[,] A= { {1,2,3,4 },{5,6,7,8} };

            for (int j = 0; j < B.Length; j++)
            {
                Console.Write($"B[{j}]={B [j]} ");
            }

            Console.WriteLine();
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write($"A[{i},{j}]={A[i,j]} ");
                }
                Console.WriteLine();
            }

        }
    }
}

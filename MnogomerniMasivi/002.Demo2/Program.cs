﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine()); //въвеждаме брой редове
            int j = int.Parse(Console.ReadLine()); //въвеждаме брой колони
            int[,] matrix = new int[i, j];

            for ( i = 0; i < matrix.GetLength(0); i++)
            {
                for ( j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"matrix[{i},{j}] = ");
                    matrix[i, j] = int.Parse(Console.ReadLine());

                }
            }

            for (i = 0; i < matrix.GetLength(0); i++)
            {
                for (j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"matrix[{i},{j}] ={matrix[i,j]} ");
                   
                }
                Console.WriteLine();
            }
        }
    }
}

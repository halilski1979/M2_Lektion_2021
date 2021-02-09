using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Stepen
{
    class Program
    {
        static double RaiseToPower(double number, int power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
                result *= number;
            return result;
        }


        static void Main(string[] args)
        {
            double osnova = double.Parse(Console.ReadLine());
            int stepen = int.Parse(Console.ReadLine());
            Console.WriteLine($"{osnova}^{stepen} = {RaiseToPower(osnova,stepen)}");
        }
    }
}

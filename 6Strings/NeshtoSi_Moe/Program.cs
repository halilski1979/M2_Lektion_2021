using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeshtoSi_Moe
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string str = "Halilski";
            Console.WriteLine(str);
            Console.WriteLine(str[2]);
            //str[2] = 'W';  //грешка

            char[] str1 = str.ToCharArray();
            Console.WriteLine(string.Join(" ",str1));

            str1[0] = '1';
            foreach (var item in str1)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            char[] char1 = { 'H', 'A', ' ', 'L', 'I', 'L' };
            Console.WriteLine(string.Join(" ",char1));

            string newChar1 = new string(char1);
            Console.WriteLine(newChar1);
        }
    }
}

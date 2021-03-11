using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_3w_ObrashtaneNiz
{
    class Program
    {
        static void  reverseString(string str)
        {
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
        }

        static string reverseString1(string str)
        {
            char[] str1 = new char[str.Length];
            int index = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                str1[index] = str[i];                            
                index++;
            }
            //Console.WriteLine(string.Join("", str1));
            string finalStr = new string(str1);
            return finalStr;
        }

        static void Main(string[] args)
        {
            string str = "Hello";

            //Първи метод
            reverseString(str);

            //Втори метод
            string newStr = reverseString1(str);
            Console.WriteLine(newStr);
           
            
        }
    }
}

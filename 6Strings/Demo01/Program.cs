using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            string str ="Hello, C#";
            Console.WriteLine(str);
            Console.WriteLine(string.Join(",", str));
            //Преобразуване на string до char array
            char[] str1 = str.ToCharArray();
            
            Console.WriteLine(string.Join(",", str1));
            foreach (var item in str1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"str1[0]={str1[0]}");
            Console.WriteLine(new string('=',20));
            //Преобразуване на char array => string
             string str2 = new String(str1);
             Console.WriteLine($"str2 = {str2}");

            string str3 = new string(new char[] { 'Y', 'e','s' });
            Console.WriteLine($"str3 = {str3}");

        }
    }
}

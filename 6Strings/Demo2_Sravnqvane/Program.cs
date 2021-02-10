using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2_Sravnqvane
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Asen";
            string str2 = "Esan";
            // result == 0 if str1 equals str2
            // result < 0 if str1 is before str2
            // result > 0 if str1 is after str2
            int result = string.Compare(str1,str2,true);
            Console.WriteLine(result);

            string slqtString = string.Concat(str1,str2);
            Console.WriteLine(slqtString);




        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_6w_Palindrom
{
    class Program
    {

        static bool palindrom(string word)
        {
            bool flag;
            string reverseWord = new string(word.Reverse().ToArray());
            if (word.CompareTo(reverseWord) == 0)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;
        }

        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(palindrom(word));
        }
    }
}

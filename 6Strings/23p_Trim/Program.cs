using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23p_Trim
{
    class Program
    {
        static void Main(string[] args)
        {
            //s.Trim() - отрязва интервалите отпред и отзад на string-a
            string s = "      I love football      " ;
            Console.WriteLine(s);
            string newS = s.Trim();
            Console.WriteLine(newS);
            //Trim(',',' ','i','n');  => Изтрива символите отпред и отзад на string-a
            string p = " ,   Asen Ivanov, uchitel:na 23 godini";
            Console.WriteLine(p);
            string newP = p.Trim(',',' ','i','n');
            Console.WriteLine(newP);

            string start = "      I love football      ";
            Console.WriteLine(start);
            string newStart = s.TrimStart();
            Console.WriteLine(newS);
        }
    }
}

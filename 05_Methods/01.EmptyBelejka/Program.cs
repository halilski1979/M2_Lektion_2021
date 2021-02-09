using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.EmptyBelejka
{
    class Program
    {
        static void PrintHeader()
        {
            Console.WriteLine("Header");
        }

        static void PrintMiddle()
        {
            Console.WriteLine("Middle");
        }

        static void PrintFooter()
        {
            Console.WriteLine("Footer");
        }

        static void PrintAll()
        {
            PrintHeader();
            PrintMiddle();
            PrintFooter();
        }

        static void Main(string[] args)
        {
            PrintAll();
        }
    }
}

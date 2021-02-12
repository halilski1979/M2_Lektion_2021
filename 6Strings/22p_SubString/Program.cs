using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22p_SubString
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"C:\Pics\Rila2017.jpg";
            string name = filename.Substring(8, 8);
            Console.WriteLine(name);  // name == "Rila2017"

            string nameAndExtension = filename.Substring(8);
            Console.WriteLine(nameAndExtension); // nameAndExtension == "Rila2017.jpg"



        }
    }
}

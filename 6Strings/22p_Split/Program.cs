using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22p_Split
{
    class Program
    {
        static void Main(string[] args)
        {
            string biriMarka ="amstel, Zagorka :Kamenica!Tuborg Shumensko" ;

            string[] biri = biriMarka.Split(' ',',',':','!').ToArray();
            Console.WriteLine(string.Join(" ",biri));
        }
    }
}

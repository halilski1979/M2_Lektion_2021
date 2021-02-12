using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22p_IndexOf1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "halilasi@abv.bg";
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine($"str[{i}]={str[i]}");
            }

            //Намира индекса на първото срещане на "а"
            int firstIndex = str.IndexOf("a");
            Console.WriteLine(firstIndex);

            //Намира индекса "а", НО започва търсенето от 8 индекс
            int secondIndex = str.IndexOf("a", 8);
            Console.WriteLine(secondIndex);

            //Отпечатва -1, ако не намери търсения символ
            int thirdIndex = str.IndexOf("!");
            Console.WriteLine(thirdIndex);

            //Връща последното срещане в стринга, и дава индекса на "b"
            string verse = "To be or not to be…";
            int lastIndex = verse.LastIndexOf("be"); // 16
            Console.WriteLine(lastIndex);
        }
    }
}

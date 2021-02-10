using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_5w_UmnStringove
{
    class Program
    {
        static int sumMultiply(string word1,string word2)
        {
               

            int shortest = Math.Min(word1.Length, word2.Length) - 1;
            int sum = 0;
            //Първата дума е по-малка
            if (word1.Length <= word2.Length)
            {
                
                for (int i = 0; i <= shortest; i++)
                {
                    sum += (int)word1[i] * (int)word2[i];
                }
                for (int i = shortest + 1; i < word2.Length; i++)
                {
                    sum += (int)word2[i];
                }
                Console.WriteLine(sum);
            }

            //Втората дума е по-малка
            if (word1.Length > word2.Length)
            {
                for (int i = 0; i <= shortest; i++)
                {
                    sum += (int)word1[i] * (int)word2[i];
                }
                for (int i = shortest + 1; i < word1.Length; i++)
                {
                    sum += (int)word1[i];
                }
                //Console.WriteLine(sum);
               
            }
            return sum;
        }


        static void Main(string[] args)
        {

            var line = Console.ReadLine().Split(' ').ToArray();
            string word1 = line[0];
            string word2 = line[1];
            sumMultiply(word1, word2);




        }
    }
}

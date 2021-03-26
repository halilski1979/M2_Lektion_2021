using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27w_3_Minyori
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> polIZK = new Dictionary<string, int>();
            while (true)
            {
                string command = Console.ReadLine();
                

                if (command=="stop")
                {
                    break;
                }


                int kol = int.Parse(Console.ReadLine());
                if (polIZK.ContainsKey(command))
                {
                    polIZK[command] += kol;
                }
                else
                {
                    polIZK.Add(command,kol);
                }


            }

            foreach (var item in polIZK)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}

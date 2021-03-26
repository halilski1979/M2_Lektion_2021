using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeshtoMoeSi
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> phoneBook = new Dictionary<string, int>();

            while (true)
            {
                var linia = Console.ReadLine().Split(' ').ToList();
                if (linia[0]=="end")
                {
                    break;
                }

                if (linia[0]=="A")
                {
                    if (phoneBook.ContainsKey(linia[0]))
                    {
                        phoneBook[linia[1]] = int.Parse(linia[2]);
                    }
                    else
                    {
                        phoneBook[linia[1]] = int.Parse(linia[2]);
                    }
                }

                if (linia[0]=="S")
                {
                    if (phoneBook.ContainsKey(linia[1]))
                    {
                        Console.WriteLine($"{linia[1]} => {phoneBook[linia[1]]} ");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {linia[1]} does not exist");    
                    }
                }

                if (linia[0]=="P")
                {
                    foreach (var item in phoneBook)
                    {
                        Console.WriteLine($"{item.Key} => {item.Value}");
                    }
                }
            }
        }
    }
}

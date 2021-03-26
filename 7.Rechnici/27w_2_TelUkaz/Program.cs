using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27w_2_TelUkaz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Under construction
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            while (true)
            {
                var linia = Console.ReadLine().Split(' ').ToList();

                if (linia[0]=="end")
                {
                    break;
                }

                if (linia[0]=="A")
                {
                   
                        if (phoneBook.ContainsKey(linia[1]))
                        {
                            phoneBook[linia[1]] = linia[2];
                        }
                             else
                            {
                                 phoneBook[linia[1]]= linia[2];
                            }
                        
                                 
                }
        
                if (linia[0] == "S")
                {
                    
                        if (phoneBook.ContainsKey(linia[1]))
                        {
                        
                        Console.WriteLine($"{linia[1]}: {phoneBook[linia[1]]}");
                        }
                    else
                    {
                        Console.WriteLine($"Contact {linia[1]} does not exist");
                    }
                }

            }
        }
    }
}

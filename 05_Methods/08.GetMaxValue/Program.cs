using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.GetMaxValue
{
    class Program
    {
        static int GetMax(int f,int s)
        {
            if (f>s)
            {
                return f;
            }
            else
            {
                return s;
            }
        }

        static char GetMax(char f, char s)
        {
            if (f > s)
            {
                return f;
            }
            else
            {
                return s;
            }
        }

        static string GetMax(string f, string s)
        {
            if (f.CompareTo(s) >= 0)
            {
                return f;
            }
            else
            {
                return s;
            }

        }

        static void Main(string[] args)
        {
            var type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    {
                        int first = int.Parse(Console.ReadLine());
                        int second = int.Parse(Console.ReadLine());
                        int max = GetMax(first, second);
                        Console.WriteLine(max);
                        break;
                    }

                case "char":
                    {
                        char first = char.Parse(Console.ReadLine());
                        char second = char.Parse(Console.ReadLine());
                        char max = GetMax(first, second);
                        Console.WriteLine(max);
                        break;
                    }

                case "string":
                    {
                        string first = Console.ReadLine();
                        string second = Console.ReadLine();
                        string max = GetMax(first, second);
                        Console.WriteLine(max);
                        break;
                    }

                default:
                    Console.WriteLine("Wrong choice!!!");
                    break;
            }
        }
    }
}

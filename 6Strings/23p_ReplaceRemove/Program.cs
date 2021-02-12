using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23p_ReplaceRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            string cocktail = "Vodka + Martini + Cherry";
            string replaced = cocktail.Replace("+","and");
            Console.WriteLine(replaced);

            string price = "123456$";
            string newPrice = price.Remove(2,4);
            Console.WriteLine(newPrice);

        }
    }
}

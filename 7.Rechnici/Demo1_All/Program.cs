using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1_All
{
    class Program
    {
        static void Main(string[] args)
        {
            //Деклариране на речник
            Dictionary<string, int> nameMoney = new Dictionary<string, int>();
            Console.Write("BrElementi: ");
            int brElRechnik = int.Parse(Console.ReadLine());



            for (int i = 0; i < brElRechnik; i++)
            {
                var linia = Console.ReadLine().Split(' ').ToList();
                string name = linia[0];
                int money = int.Parse(linia[1]);

                if (nameMoney.ContainsKey(name))
                   //Ако съществува такова име, името си остава, но взема нова стойност
                {
                    nameMoney[name] = money;
                    i--;
                }
                else
                    //Ако не съществува такова име, го добавя към речника
                    nameMoney.Add(name, money);
               
            }

            //Отпечатване
            foreach (var item in nameMoney)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
            Console.WriteLine(string.Join("|",nameMoney.Keys));
            Console.WriteLine(string.Join("=", nameMoney.Values));
            Console.WriteLine();
            //Изтриване на елемент от речника по ключ
            Console.WriteLine("Изберете елемент от речника за изтриване: ");
            string nameDel = Console.ReadLine();
            nameMoney.Remove(nameDel);
            foreach (var item in nameMoney)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }

            //Сортиране по ключ
            Console.WriteLine("SortByKey:==========");
            nameMoney = nameMoney.OrderBy(x => x.Key).ToDictionary(x=>x.Key,x=>x.Value);
            foreach (var item in nameMoney)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }

            //Сортиране по стойност
            Console.WriteLine("SortByValue:==========");
            nameMoney = nameMoney.OrderByDescending(x => x.Value).ToDictionary(x=>x.Key,x=>x.Value);
            foreach (var item in nameMoney)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }

            var spisakKeys = nameMoney.Keys.ToList();
            var spisakValue = nameMoney.Values.ToList();
        }
    }
}

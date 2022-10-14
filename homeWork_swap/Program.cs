using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Фазлетдинов";
            string surname = "Данил";
            string swapText;

            Console.WriteLine($"Имя: {name}.\nФамилия: {surname}");

            swapText = name;
            name = surname;
            surname = swapText;
            Console.WriteLine($"Имя: {name}.\nФамилия: {surname}");
            Console.ReadKey();
        }
    }
}

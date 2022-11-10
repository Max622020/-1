using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторна_робота_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Лабораторна робота №1 на тему: <СТРУКТУРА КОНСОЛЬНОГО ДОДАТКУ В C #>");
            Console.WriteLine("");
            Console.WriteLine("Варiант №6");
            Console.WriteLine("");
            Console.WriteLine("Виконав:Харченко Максим Олександрович");
            Console.WriteLine("");
            Console.WriteLine("Група: ЕС-137Бстн");
            Console.WriteLine("");
            Console.WriteLine("Введiть число X - (2,26), щоб отримати вiдповiдь = 0,235");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = (Math.Cos(1.5 * x) - (Math.Pow(Math.E, (Math.Sin(x + (4 / 3.0))))) + (Math.Sqrt(x + (7 / 6.0))));
            Console.WriteLine(" x = {0} \t y = {1} ",
            x, y);
            Console.ReadKey();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = InputReader.GetIntValue("Введиет радиус курга");

            Console.WriteLine("Создаем круг радиусом {0} с центром в координатах (0, 0): Round o = new Round(0, 0, 5)", r);
            Round o = new Round(0, 0, r);
            Console.WriteLine("Получаем радиус: o.R = {0}", o.R);
            Console.WriteLine("Получаем длину окружности: o.L = {0}", o.L);
            Console.WriteLine("Получаем площадь круга: o.S = {0}", o.S);
            Console.ReadKey();
        }
    }
}

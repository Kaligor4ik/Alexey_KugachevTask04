using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task02;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {

            int A = InputReader.GetIntValue("Введиет сторону A");
            int B = InputReader.GetIntValue("Введиет сторону B");
            int C = InputReader.GetIntValue("Введиет сторону C");

            Console.WriteLine("Создаем треугольник со сторонами {0}, {1}, {2}", A, B, C);
            Triangle o = new Triangle(A, B, C);
            Console.WriteLine("Получаем периметр: o.P = {0}", o.P);
            Console.WriteLine("Получаем площадь: o.S = {0}", o.S);
            Console.ReadKey();
        }
    }
}

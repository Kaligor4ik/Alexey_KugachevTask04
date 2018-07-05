using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Triangle
    {
        private readonly int a;
        private readonly int b;
        private readonly int c;

        public Triangle(int a, int b, int c)
        {            
            this.a = Math.Abs(a);
            this.b = Math.Abs(b);
            this.c = Math.Abs(c);
            if (a + b < c | a + c < b | b + c < a)
            {
                Console.WriteLine("По заданным сторонам нельзя построить треугольник");
                Console.ReadKey();
                throw new Exception("По заданным сторонам нельзя построить треугольник");
            }
        }

        public int A => a; 
        public int B => b;
        public int C => c;
        public double P => a + b + c;
        public double PP => P/2;
        public double S => Math.Sqrt(PP*(PP - a)*(PP - b) *(PP - c));
    }
}

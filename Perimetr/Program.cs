using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimetr
{
    internal class Program
    {
        static int Perimetr(int a, int b, int c)
        {
            return a + b + c;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите три стороны треугольника: ");
                int katet_1 = int.Parse(Console.ReadLine());
                int katet_2 = int.Parse(Console.ReadLine());
                int gipot = int.Parse(Console.ReadLine());
                Console.WriteLine($"Периметр равен: {Perimetr(katet_1, katet_2, gipot)}");
            }
        }
    }
}

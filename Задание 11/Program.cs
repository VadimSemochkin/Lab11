using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует супер мега программа для решения линейных уравнений вида 0=kx+b, которые невозможно решить вручную");
            Console.WriteLine("Введите коэффициенты уравнения: k и b");
            Equation eq = new Equation { k = Convert.ToInt32(Console.ReadLine()), b = Convert.ToInt32(Console.ReadLine()) };
            eq.Root();
            Console.ReadKey();
        }

        struct Equation
        {
            public float x;
            public float k;
            public float b;

            public void Root()
            {
                x = -b / k;
                Console.WriteLine("Решение уравнения {0}", x);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana7___Ejercicios
{
    internal class Ejercicio14
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Ingrese un número: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            TablaMultiplicar(num);

            Console.ReadKey();
        }

        static void TablaMultiplicar(int num)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }
    }
}
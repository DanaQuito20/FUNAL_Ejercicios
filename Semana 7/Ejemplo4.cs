using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana7
{
    internal class Ejemplo4
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Ingrese el primer número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            Suma(num1, num2);

            Console.ReadKey();
        }

        static void Suma(int num1, int num2)
        {
            Console.WriteLine($"\nEl resultado de la suma es de {num1 + num2}");
        }
    }
}
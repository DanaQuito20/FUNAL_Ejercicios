using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana5._2
{
    internal class Ejercicio4
    {
        static void Main(string[] args)
        {
            int numeros, cantNum, cantP = 0, cantI = 0, cantC = 0;

            Console.Write("Ingrese la cantidad de números: ");
            cantNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= cantNum; i++)
            {
                Console.Write($"Ingrese el número {i}: ");
                numeros = Convert.ToInt32(Console.ReadLine());

                if (numeros == 0) cantC++;
                else if (numeros % 2 == 0) cantP++;
                else cantI++;
            }

            Console.WriteLine($"\nLa cantidad de pares es de {cantP}, la de impares de {cantI} y la de ceros de {cantC}");

            Console.ReadKey();
        }
    }
}
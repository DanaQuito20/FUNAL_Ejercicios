using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana7___Ejercicios
{
    internal class Ejercicio7
    {
        static void Main(string[] args)
        {
            Notas();

            Console.ReadKey();
        }

        static void Notas()
        {
            int notas, suma = 0;
            double promedio;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Ingrese la nota {i}: ");
                notas = int.Parse(Console.ReadLine());

                suma += notas;
            }

            promedio = suma / 5.0;

            if (promedio >= 12) Console.WriteLine($"\nSu promedio es de {promedio}, usted aprobó.");
            else Console.WriteLine($"\nSu promedio es de {promedio}, usted desaprobó.");
        }
    }
}
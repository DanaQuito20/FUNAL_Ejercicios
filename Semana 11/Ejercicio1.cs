using System;

namespace Semana10
{
    internal class Ejercicio1
    {
        static void Main(string[] args)
        {
            //Declarar variables
            double promedio, acumulador = 0;

            //Declaramos el arreglo
            double[] Notas = new double[5];

            //Creamos la estructura repetitiva para ingresar las notas
            for (int i = 0; i < Notas.Length; i++)
            {
                //Pedimos ingresar una nota
                Console.Write($"Ingrese la nota {i + 1}: ");
                Notas[i] = Convert.ToDouble(Console.ReadLine());

                //Agregamos al acumulador
                acumulador = acumulador + Notas[i];
            }

            //Calculamos el promedio
            promedio = acumulador / 5;

            //Limpiamos pantalla
            Console.Clear();

            //Mostramos cada una de las notas ingresadas
            for (int i = 0; i < Notas.Length; i++)
            {
                Console.WriteLine($"La nota {i + 1} es: {Notas[i]}");
            }

            //Mostramos el promedio final
            Console.WriteLine($"\nEl promedio es: {promedio}");

            Console.ReadKey();
        }
    }
}
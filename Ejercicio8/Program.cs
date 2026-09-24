using System;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador, notas, sumaNotas = 0, estuAprobados = 0, acumulador = 0;
            double promedio;

            for(contador = 0; contador < 5; contador++)
            {
                Console.Write($"Ingrese la nota del estudiante {contador + 1}: ");
                notas = Convert.ToInt32(Console.ReadLine());

                sumaNotas += notas;

                if (notas >= 11) estuAprobados++;
            }

            promedio = sumaNotas / 5.0;

            Console.WriteLine($"\nEl promedio de las notas es {promedio}, y la cantidad de aprobados es de {estuAprobados}");

            Console.ReadLine();
        }
    }
}
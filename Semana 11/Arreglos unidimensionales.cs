using System;

namespace Semana10
{
    internal class Arreglos_unidimensionales
    {
        static void Main(string[] args)
        {
            //Cómo declarar un arreglo unidimensional -> tipoDato[] nombreArreglo = new tipoDato[tamaño]

            //Creamos un arreglo para almacenar 5 notas
            int[] notas = new int[5];

            //Agregamos valores al arreglo "Notas" en cada índice
            notas[0] = 15;
            notas[1] = 10;
            notas[2] = 20;
            notas[3] = 5;
            notas[4] = 7;

            //Declaramos un arreglo unidimensional asignando sus valores al momento de declarar
            int[] notas2 = new int[4] {4, 15, 17, 3};
            //Observación: Si declaramos el tamaño del arreglo, la cantidad de datos a ingresar debe ser del tamaño del arreglo

            //Declaramos un arreglo sin tamaño e ingresamos sus datos
            int[] notas3 = new int[] {12, 15, 5, 7, 20};

            //Extraer los datos de un arreglo usando una estructura repetitiva
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Nota {i + 1}: {notas[i]}");
            }

            //Extraer los datos de un arreglo usando una estructura repetitiva con la función ".Lenght" (Solo lo usamos para calcular el tamaño de arreglos unidimensionales)
            for (int i = 0; i < notas3.Length; i++)
            {
                Console.WriteLine($"Nota {i + 1}: {notas3[i]}");
            }
        }
    }
}
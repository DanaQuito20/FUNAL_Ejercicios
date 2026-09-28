using System;

namespace Semana7
{
    internal class Ejemplo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============================");
            Console.WriteLine("      PROGRAMA DE SALUDO      ");
            Console.WriteLine("==============================");

            //Llamamos a nuestra función Saludar()
            Saludar();

            Console.ReadKey();
        }

        //Creamos el método Saludar() - Método sin parámetros y sin retorno
        static void Saludar()
        {
            //Declaramos variables
            string nombre;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine($"\nHola, {nombre}. Bienvenido al curso de Fundamentos de Algoritmos.");
        }
    }
}
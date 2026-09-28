using System;

namespace Semana7
{
    internal class Ejemplo3
    {
        static void Main(string[] args)
        {
            //Declaramos variables
            string nombre;
            int edad;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            //Llamamos al método con parámetros y sin retorno
            Saludar(nombre, edad);

            Console.ReadKey();
        }

        static void Saludar(string nombre, int edad)
        {
            Console.WriteLine($"\nHola {nombre}, bienvenido al curso.");

            if (edad >= 18) Console.WriteLine("Eres mayor de edad.");
            else Console.WriteLine("Eres menor de edad.");
        }
    }
}
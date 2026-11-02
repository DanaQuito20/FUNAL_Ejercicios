using System;
using System.ComponentModel.Design;
using Semana_12___Biblioteca;

namespace Semana_12
{
    internal class Ejercicio_1
    {
        static void Main(string[] args)
        {
            //Declaramos la variable opción
            int opcion = Menú.opcionElegida();

            Console.WriteLine($"Usted seleccionó la opción {opcion + 1}.");
        }
    }
}
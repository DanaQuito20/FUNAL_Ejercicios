using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana12
{
    internal class Ejercicio
    {
        static void Main(string[] args)
        {
            Estudiantes Estudiantes = new Estudiantes();
            string continuar; int opcion;

            do
            {
                Console.WriteLine("***********************************************************************");
                Console.WriteLine("*     Bienvenidos al sistema de registro de edades de estudiantes     *");
                Console.WriteLine("*---------------------------------------------------------------------*");
                Console.WriteLine("*                             0. Salir                                *");
                Console.WriteLine("*                             1. Insertar                             *");
                Console.WriteLine("*                             2. Mostrar                              *");
                Console.WriteLine("*                             3. Eliminar                             *");
                Console.WriteLine("*                             4. Ordenar                              *");
                Console.WriteLine("***********************************************************************");

                do
                {
                    Console.Write("Ingrese una opción: ");
                    if (int.TryParse(Console.ReadLine(), out opcion) && opcion >= 0 && opcion <= 4) break;
                    else Console.WriteLine("Error. Ingrese un número del 0 al 4.");
                } while (true);

                switch (opcion)
                {
                    case 0: Environment.Exit(0); break;
                    case 1: Estudiantes.Insertar(); break;
                    case 2: Estudiantes.Mostrar(); break;
                    case 3: Estudiantes.Eliminar(); break;
                    case 4: Estudiantes.Ordenar(); break;
                }

                do
                {
                    Console.Write("\n¿Desea regresar al menú? (SI / NO): ");
                    continuar = Console.ReadLine().ToUpper().Trim();

                    if (continuar != "SI" && continuar != "NO") Console.WriteLine("Error. Ingrese solo SI o NO.\n");
                } while (continuar != "SI" && continuar != "NO");
                Console.Clear();
            } while (continuar == "SI");

            Console.ReadKey();
        }
    }
}
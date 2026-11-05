using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana12
{
    internal class Estudiantes
    {
        byte[] Edades = new byte[0]; int cantidad = 0;

        public void Insertar()
        {
            byte edad; string continuar;

            do
            { 
                do
                {
                    Console.Write("\nIngrese la edad del estudiante: ");
                    if (byte.TryParse(Console.ReadLine(), out edad) && edad >= 14 && edad <= 120) break;
                    else Console.WriteLine("Error. Ingrese una edad entre 14 y 120.");
                } while (true);

                Array.Resize(ref Edades, Edades.Length + 1); Edades[cantidad] = edad; cantidad++;

                Console.WriteLine("¡Edad ingresada con éxito!");

                do
                {
                    Console.Write("\n¿Desea ingresar otra edad? (SI / NO): ");
                    continuar = Console.ReadLine().ToUpper().Trim();

                    if (continuar != "SI" && continuar != "NO") Console.WriteLine("Error. Ingrese solo SI o NO.\n");
                } while (continuar != "SI" && continuar != "NO");
            } while (continuar == "SI");
        }

        public void Mostrar()
        {
            Console.WriteLine("\nPosición\tEdades");
            for (int i = 0; i < Edades.Length; i++)
            {
                Console.WriteLine($"* {i + 1}\t\t* {Edades[i]}");
            }
        }

        public void Eliminar()
        {

        }

        public void Ordenar()
        {

        }
    }
}
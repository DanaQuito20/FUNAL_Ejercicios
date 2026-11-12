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

        public void Eliminar(byte edad)
        {
            int indice = Array.IndexOf(Edades, edad); string continuar;

            do
            {
                if (indice != -1)
                {
                    for (int i = indice; i < Edades.Length - 1; i++) Edades[i] = Edades[i + 1];
                    Array.Resize(ref Edades, Edades.Length - 1); cantidad--;
                    Console.WriteLine("\n¡Edad eliminada con éxito!");
                }
                else Console.WriteLine("La edad no existe en el arreglo.");

                do
                {
                    Console.Write("\n¿Desea eliminar otra edad? (SI / NO): ");
                    continuar = Console.ReadLine().ToUpper().Trim();
                    if (continuar != "SI" && continuar != "NO") Console.WriteLine("Error. Ingrese solo SI o NO.\n");
                } while (continuar != "SI" && continuar != "NO");
            } while (continuar == "SI");
        }

        public void Ordenar()
        {
            for (int i = 0; i < Edades.Length - 1; i++)
            {
                for (int j = 0; j < Edades.Length - 1 - i; j++)
                {
                    if (Edades[j] < Edades[j + 1])
                    {
                        byte temporal = Edades[j];
                        Edades[j] = Edades[j + 1];
                        Edades[j + 1] = temporal;
                    }
                }
            }
            Console.WriteLine("\n¡Edades ordenadas con éxito!");
        }
    }
}
using System;

namespace Semana10
{
    internal class Ejercicio3
    {
        static void Main(string[] args)
        {
            int[] num = new int[8] {3, 6, 4, 1, 43, 65, 32, 46};

            Console.Write("Ingrese un número para comprobar que existe en el arreglo o no: ");
            int existe = int.Parse(Console.ReadLine());

            for (int i = 0; i < 8; i++)
            {
                if (num[i] == existe)
                {
                    Console.Write("\nEl número existe.");
                    break;
                }
                else
                {
                    Console.Write("\nEl número no existe."); break;
                }
            }

            Console.ReadKey();
        }
    }
}
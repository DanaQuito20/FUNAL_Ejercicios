using System;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador;

            for (contador = 1; contador <= 20; contador++)
            {
                contador++;
                Console.WriteLine(contador);
            }

            Console.ReadLine();
        }
    }
}
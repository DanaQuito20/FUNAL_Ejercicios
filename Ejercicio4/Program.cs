using System;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador, numPares = 0;

            for (contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine(contador);

                if (contador % 2 == 0) numPares++;
            }

            Console.WriteLine($"\nLa cantidad de números pares es de {numPares}");

            Console.ReadLine();
        }
    }
}